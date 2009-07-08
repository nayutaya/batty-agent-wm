
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
        private SystemState timeState;
        private SystemState batteryModeState;
        private SystemState batteryStrengthState;
        private DateTime lastUpdate = DateTime.Now;
        private Setting setting;
        private Logger logger = new Logger();
        private RecordManager recordManager;
        private bool initialized = false;

        public MainForm()
        {
            InitializeComponent();

            this.AddLog("起動しています");

            (new Thread(new ThreadStart(delegate
            {
                this.LoadSetting();
                this.LoadRecordManager();
                this.SetupSystemStates();
                this.initialized = true;
                this.AddLog("起動しました");
            }))).Start();
        }

        private void LoadSetting()
        {
            this.setting = new Setting();

            SettingManager settingManager = new SettingManager();
            settingManager.Load(this.setting);
        }

        private void LoadRecordManager()
        {
            this.recordManager = new RecordManager();
            this.recordManager.Load();
        }

        private void SetupSystemStates()
        {
            this.timeState = new SystemState(SystemProperty.Time);
            this.timeState.Changed += new ChangeEventHandler(timeState_Changed);
            this.batteryModeState = new SystemState(SystemProperty.PowerBatteryState);
            this.batteryModeState.Changed += new ChangeEventHandler(batteryModeState_Changed);
            this.batteryStrengthState = new SystemState(SystemProperty.PowerBatteryStrength);
            this.batteryStrengthState.Changed += new ChangeEventHandler(batteryStrengthState_Changed);
        }

        private void timeState_Changed(object sender, ChangeEventArgs args)
        {
            if ( !this.initialized ) return;

            DateTime now = DateTime.Now;
            DateTime nextUpdate = this.lastUpdate.AddMinutes(this.setting.RecordOnIntervalMinute).AddSeconds(-30);
            if ( now >= nextUpdate )
            {
                this.AddLog(String.Format("{0}分経過しました", this.setting.RecordOnIntervalMinute));
                this.lastUpdate = now;
                this.Send();
            }
        }

        void batteryModeState_Changed(object sender, ChangeEventArgs args)
        {
            if ( !this.initialized ) return;

            this.AddLog("電源/充電状態が変化しました");
            this.lastUpdate = DateTime.Now;
            this.Send();
        }

        void batteryStrengthState_Changed(object sender, ChangeEventArgs args)
        {
            if ( !this.initialized ) return;

            this.AddLog("バッテリレベルが変化しました");
            this.lastUpdate = DateTime.Now;
            this.Send();
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

        private void sendButton_Click(object sender, EventArgs e)
        {
            if ( !this.initialized ) return;

            this.AddLog("手動送信");
            this.Send();
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

            if ( this.setting.EnableLevelLog )
            {
                this.logger.Write(DateTime.Now, level);
            }

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
