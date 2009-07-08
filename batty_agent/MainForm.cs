
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Threading;
using Microsoft.WindowsMobile.Status;

namespace nayutaya.batty.agent
{
    public partial class MainForm : Form
    {
        private Setting setting;
        private RecordManager recordManager;
        private Logger logger;
        private SystemState timeState;
        private SystemState batteryLevelState;
        private SystemState batteryChargeState;
        private bool initialized = false;
        private DateTime lastUpdate = DateTime.Now;
        private DateTime lastRecord = DateTime.Now;
        private DateTime lastSend = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();
        }

        private void SetupSetting()
        {
            this.setting = new Setting();

            SettingManager settingManager = new SettingManager();
            settingManager.Load(this.setting);
        }

        private void SetupRecordManager()
        {
            this.recordManager = new RecordManager();
            this.recordManager.Load();
        }

        private void SetupLogger()
        {
            this.logger = new Logger();
        }

        private delegate void MethodInvoker();
        private void SetupSystemStates()
        {
            this.timeState = new SystemState(SystemProperty.Time);
            this.batteryLevelState = new SystemState(SystemProperty.PowerBatteryStrength);
            this.batteryChargeState = new SystemState(SystemProperty.PowerBatteryState);

            this.Invoke(new MethodInvoker(delegate
            {
                this.timeState.Changed += new ChangeEventHandler(timeState_Changed);
                this.batteryLevelState.Changed += new ChangeEventHandler(batteryLevelState_Changed);
                this.batteryChargeState.Changed += new ChangeEventHandler(batteryChargeState_Changed);
            }));
        }

        private delegate void AddLogDelegate(string message);
        private void AddLog(string message)
        {
            if ( this.InvokeRequired )
            {
                this.Invoke(new AddLogDelegate(this.AddLog), message);
                return;
            }

            DateTime dt = DateTime.Now;

            ListViewItem lvi = new ListViewItem();
            lvi.Text = dt.ToString("hh:mm:ss");
            lvi.SubItems.Add(message);

            this.listView1.Items.Insert(0, lvi);

            while ( this.listView1.Items.Count > 20 )
            {
                this.listView1.Items.RemoveAt(20);
            }
        }

        private string CreateUpdateUrl(string deviceToken, string level)
        {
            string host = "batty.nayutaya.jp";
            string path = "http://" + host + "/device/token/" + deviceToken + "/energies/update";
            return path + "/" + level;
        }

        private WebRequest CreateUpdateRequest(string deviceToken, string level)
        {
            string url = this.CreateUpdateUrl(deviceToken, level);
            WebRequest request = WebRequest.Create(url);
            request.Method = "POST";
            request.Timeout = 20 * 1000;

            return request;
        }

        private void RecordLevel()
        {
            this.lastRecord = DateTime.Now;

            BatteryStatus bs = new BatteryStatus();

            if ( !this.setting.EnableRecordOnBatteryCharging )
            {
                if ( !bs.Charging.HasValue )
                {
                    this.AddLog("充電状態が不明です");
                    return;
                }
                if ( bs.Charging.Value )
                {
                    this.AddLog("充電中のため記録しませんでした");
                    return;
                }
            }

            if ( !this.setting.EnableRecordOnPowerConnecting )
            {
                if ( !bs.PowerLineConnecting.HasValue )
                {
                    this.AddLog("電源状態が不明です");
                    return;
                }
                if ( bs.PowerLineConnecting.Value )
                {
                    this.AddLog("電源接続中のため記録しませんでした");
                    return;
                }
            }

            if ( !bs.LifePercent.HasValue )
            {
                this.AddLog("バッテリレベルが不明です");
                return;
            }

            Record record = new Record(DateTime.Now, bs.LifePercent.Value);
            this.recordManager.Add(record);
            this.recordManager.Save();

            if ( this.setting.EnableLevelLog )
            {
                this.logger.Write(DateTime.Now, bs.LifePercent.Value);
            }

            this.AddLog("記録しました");
        }

        private void SendLevel()
        {
            this.lastSend = DateTime.Now;

            List<Record> records = this.recordManager.GetUnsentRecords();
            if ( records.Count < 1 )
            {
                return;
            }

            this.AddLog(String.Format("{0}件の未送信レコードがあります", records.Count));

            string deviceToken = this.setting.DeviceToken;

            foreach ( Record record in records )
            {
                WebRequest request = this.CreateUpdateRequest(deviceToken, record.Level.ToString());

                try
                {
                    using ( WebResponse response = request.GetResponse() )
                    {
                        this.recordManager.MarkSent(record.Time, record.Level);
                        this.AddLog("1件送信しました");
                    }
                }
                catch ( Exception ex )
                {
                    this.AddLog(ex.GetType().Name + ": " + ex.Message);
                    break;
                }
            }

            this.AddLog("送信しました");
        }

        private bool Send()
        {
            BatteryStatus bs = new BatteryStatus();

            if ( !bs.PowerLineConnecting.HasValue )
            {
                this.AddLog("電源状態が不明です");
                return false;
            }
            /*
            if ( bs.PowerLineConnecting.Value )
            {
                this.AddLog("電源接続中です");
                return false;
            }
             */
            if ( !bs.Charging.HasValue )
            {
                this.AddLog("充電状態が不明です");
                return false;
            }
            /*
            if ( bs.Charging.Value )
            {
                this.AddLog("充電中です");
                return false;
            }
             */
            if ( !bs.LifePercent.HasValue )
            {
                this.AddLog("バッテリレベルが不明です");
                return false;
            }

            string deviceToken = this.setting.DeviceToken;
            byte level = bs.LifePercent.Value;


            WebRequest request = this.CreateUpdateRequest(deviceToken, level.ToString());

            try
            {
                using ( WebResponse response = request.GetResponse() )
                {
                    this.AddLog("送信しました");
                    return true;
                }
            }
            catch ( Exception ex )
            {
                this.AddLog(ex.GetType().Name + ": " + ex.Message);
                return false;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if ( !this.initialized )
            {
                (new Thread(new ThreadStart(delegate
                {
                    this.AddLog("起動しています");
                    this.SetupSetting();
                    this.SetupRecordManager();
                    this.SetupLogger();
                    this.SetupSystemStates();
                    this.initialized = true;
                    this.AddLog("起動しました");
                }))).Start();
            }
        }

        private void timeState_Changed(object sender, ChangeEventArgs args)
        {
            if ( !this.initialized ) return;

            DateTime now = DateTime.Now;

            DateTime nextRecord = this.lastRecord.AddMinutes(this.setting.RecordOnIntervalMinute).AddSeconds(-30);
            if ( this.setting.RecordOnInterval && now >= nextRecord )
            {
                this.AddLog(String.Format("記録: {0}分経過しました", this.setting.RecordOnIntervalMinute));
                this.RecordLevel();
            }

            DateTime nextSend = this.lastSend.AddMinutes(this.setting.SendOnIntervalMinute).AddSeconds(-30);
            if ( this.setting.SendOnInterval && now >= nextSend )
            {
                this.AddLog(String.Format("送信: {0}分経過しました", this.setting.SendOnIntervalMinute));
                this.SendLevel();
            }

            if ( this.setting.SendOnCount && this.recordManager.UnsentCount >= this.setting.SendOnCountRecord )
            {
                this.AddLog(String.Format("送信: {0}件溜まりました", this.setting.SendOnCountRecord));
                this.SendLevel();
            }

            /*
            DateTime nextUpdate = this.lastUpdate.AddMinutes(this.setting.RecordOnIntervalMinute).AddSeconds(-30);
            if ( now >= nextUpdate )
            {
                this.AddLog(String.Format("{0}分経過しました", this.setting.RecordOnIntervalMinute));
                this.lastUpdate = now;
                this.Send();
            }
             */
        }

        void batteryLevelState_Changed(object sender, ChangeEventArgs args)
        {
            if ( !this.initialized ) return;

            if ( this.setting.RecordOnChangeLevelState )
            {
                this.AddLog("記録: バッテリレベルが変化しました");
                this.RecordLevel();
            }

            if ( this.setting.SendOnChangeLevelState )
            {
                this.AddLog("送信: バッテリレベルが変化しました");
                this.SendLevel();
            }

            if ( this.setting.SendOnCount && this.recordManager.UnsentCount >= this.setting.SendOnCountRecord )
            {
                this.AddLog(String.Format("送信: {0}件溜まりました", this.setting.SendOnCountRecord));
                this.SendLevel();
            }

            /*
            this.AddLog("バッテリレベルが変化しました");
            this.lastUpdate = DateTime.Now;
            this.Send();
             */
        }

        void batteryChargeState_Changed(object sender, ChangeEventArgs args)
        {
            if ( !this.initialized ) return;

            if ( this.setting.RecordOnChangeChargeState )
            {
                this.AddLog("記録: 電源/充電状態が変化しました");
                this.RecordLevel();
            }

            if ( this.setting.SendOnChangeChargeState || (this.setting.SendOnCount && this.recordManager.Count >= this.setting.SendOnCountRecord) )
            {
                this.AddLog("送信: 電源/充電状態が変化しました");
                this.SendLevel();
            }

            if ( this.setting.SendOnCount && this.recordManager.UnsentCount >= this.setting.SendOnCountRecord )
            {
                this.AddLog(String.Format("送信: {0}件溜まりました", this.setting.SendOnCountRecord));
                this.SendLevel();
            }

            /*
            this.AddLog("電源/充電状態が変化しました");
            this.lastUpdate = DateTime.Now;
            this.Send();
             */
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showCurrentLevelButton_Click(object sender, EventArgs e)
        {
            if ( !this.initialized ) return;

            BatteryStatus battery = new BatteryStatus();
            this.AddLog("バッテリ残量: " + (battery.LifePercent.HasValue ? battery.LifePercent.ToString() + " %" : "不明"));
            this.AddLog("充電中: " + (battery.Charging.HasValue ? (battery.Charging.Value ? "はい" : "いいえ") : "不明"));
            this.AddLog("電源接続中: " + (battery.PowerLineConnecting.HasValue ? (battery.PowerLineConnecting.Value ? "はい" : "いいえ") : "不明"));
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            if ( !this.initialized ) return;

            this.AddLog("手動送信");
            this.RecordLevel();
            this.SendLevel();
            /*
            this.Send();
             */
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            if ( !this.initialized ) return;

            SettingForm form = new SettingForm();
            form.LoadFrom(this.setting);
            form.ShowDialog();
            form.SaveTo(this.setting);

            SettingManager settingManager = new SettingManager();
            settingManager.Save(this.setting);
        }
    }
}
