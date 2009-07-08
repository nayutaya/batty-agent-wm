namespace nayutaya.batty.agent
{
    partial class SettingForm
    {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if ( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.settingTab = new System.Windows.Forms.TabControl();
            this.generalTabPage = new System.Windows.Forms.TabPage();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.validTokenLabel = new System.Windows.Forms.Label();
            this.deviceTokenTextBox = new System.Windows.Forms.TextBox();
            this.invalidTokenLabel = new System.Windows.Forms.Label();
            this.recordTabPage = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.enableLevelLogCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.enableRecordOnBatteryChargingCheckBox = new System.Windows.Forms.CheckBox();
            this.enableRecordOnPowerConnectingCheckBox = new System.Windows.Forms.CheckBox();
            this.recordTimingTabPage = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.recordOnIntervalCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.recordOnIntervalMinuteComboBox = new System.Windows.Forms.ComboBox();
            this.recordOnChangeChargeStateCheckBox = new System.Windows.Forms.CheckBox();
            this.recordOnChangeLevelStateCheckBox = new System.Windows.Forms.CheckBox();
            this.sendTimingTabPage = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.sendOnIntervalCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.sendOnCountCheckBox = new System.Windows.Forms.CheckBox();
            this.sendOnIntervalMinuteComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sendOnChangeChargeStateCheckBox = new System.Windows.Forms.CheckBox();
            this.sendOnCountRecordComboBox = new System.Windows.Forms.ComboBox();
            this.sendOnChangeLevelStateCheckBox = new System.Windows.Forms.CheckBox();
            this.settingTab.SuspendLayout();
            this.generalTabPage.SuspendLayout();
            this.panel6.SuspendLayout();
            this.recordTabPage.SuspendLayout();
            this.panel7.SuspendLayout();
            this.recordTimingTabPage.SuspendLayout();
            this.panel8.SuspendLayout();
            this.sendTimingTabPage.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // settingTab
            // 
            this.settingTab.Controls.Add(this.generalTabPage);
            this.settingTab.Controls.Add(this.recordTabPage);
            this.settingTab.Controls.Add(this.recordTimingTabPage);
            this.settingTab.Controls.Add(this.sendTimingTabPage);
            this.settingTab.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingTab.Location = new System.Drawing.Point(0, 0);
            this.settingTab.Name = "settingTab";
            this.settingTab.SelectedIndex = 0;
            this.settingTab.Size = new System.Drawing.Size(240, 268);
            this.settingTab.TabIndex = 0;
            // 
            // generalTabPage
            // 
            this.generalTabPage.Controls.Add(this.panel6);
            this.generalTabPage.Location = new System.Drawing.Point(0, 0);
            this.generalTabPage.Name = "generalTabPage";
            this.generalTabPage.Size = new System.Drawing.Size(240, 245);
            this.generalTabPage.Text = "基本";
            // 
            // panel6
            // 
            this.panel6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.label6);
            this.panel6.Controls.Add(this.validTokenLabel);
            this.panel6.Controls.Add(this.deviceTokenTextBox);
            this.panel6.Controls.Add(this.invalidTokenLabel);
            this.panel6.Location = new System.Drawing.Point(7, 7);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(226, 235);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(220, 16);
            this.label6.Text = "デバイストークン";
            // 
            // validTokenLabel
            // 
            this.validTokenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.validTokenLabel.ForeColor = System.Drawing.Color.Green;
            this.validTokenLabel.Location = new System.Drawing.Point(3, 43);
            this.validTokenLabel.Name = "validTokenLabel";
            this.validTokenLabel.Size = new System.Drawing.Size(220, 32);
            this.validTokenLabel.Text = "デバイストークンは正しい形式です。";
            // 
            // deviceTokenTextBox
            // 
            this.deviceTokenTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.deviceTokenTextBox.Location = new System.Drawing.Point(3, 19);
            this.deviceTokenTextBox.MaxLength = 20;
            this.deviceTokenTextBox.Name = "deviceTokenTextBox";
            this.deviceTokenTextBox.Size = new System.Drawing.Size(220, 21);
            this.deviceTokenTextBox.TabIndex = 0;
            this.deviceTokenTextBox.TextChanged += new System.EventHandler(this.deviceTokenTextBox_TextChanged);
            // 
            // invalidTokenLabel
            // 
            this.invalidTokenLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.invalidTokenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.invalidTokenLabel.Location = new System.Drawing.Point(3, 43);
            this.invalidTokenLabel.Name = "invalidTokenLabel";
            this.invalidTokenLabel.Size = new System.Drawing.Size(220, 32);
            this.invalidTokenLabel.Text = "デバイストークンが正しい形式ではありません。";
            // 
            // recordTabPage
            // 
            this.recordTabPage.Controls.Add(this.panel7);
            this.recordTabPage.Location = new System.Drawing.Point(0, 0);
            this.recordTabPage.Name = "recordTabPage";
            this.recordTabPage.Size = new System.Drawing.Size(240, 245);
            this.recordTabPage.Text = "記録";
            // 
            // panel7
            // 
            this.panel7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.enableLevelLogCheckBox);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.enableRecordOnBatteryChargingCheckBox);
            this.panel7.Controls.Add(this.enableRecordOnPowerConnectingCheckBox);
            this.panel7.Location = new System.Drawing.Point(7, 7);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(226, 235);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.Location = new System.Drawing.Point(33, 171);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(190, 48);
            this.label9.Text = "バッテリ残量のログを、logディレクトリに保存します。1日1ファイルとして保存されます。";
            // 
            // enableLevelLogCheckBox
            // 
            this.enableLevelLogCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.enableLevelLogCheckBox.Location = new System.Drawing.Point(3, 148);
            this.enableLevelLogCheckBox.Name = "enableLevelLogCheckBox";
            this.enableLevelLogCheckBox.Size = new System.Drawing.Size(220, 20);
            this.enableLevelLogCheckBox.TabIndex = 2;
            this.enableLevelLogCheckBox.Text = "バッテリ残量のログを保存する";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.Location = new System.Drawing.Point(33, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(190, 48);
            this.label8.Text = "電源接続中にバッテリ残量が正しく取得できない場合は、チェックを外してください。";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.Location = new System.Drawing.Point(33, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(190, 48);
            this.label7.Text = "充電中にバッテリ残量が正しく取得できない場合は、チェックを外してください。";
            // 
            // enableRecordOnBatteryChargingCheckBox
            // 
            this.enableRecordOnBatteryChargingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.enableRecordOnBatteryChargingCheckBox.ForeColor = System.Drawing.Color.Red;
            this.enableRecordOnBatteryChargingCheckBox.Location = new System.Drawing.Point(3, 0);
            this.enableRecordOnBatteryChargingCheckBox.Name = "enableRecordOnBatteryChargingCheckBox";
            this.enableRecordOnBatteryChargingCheckBox.Size = new System.Drawing.Size(220, 20);
            this.enableRecordOnBatteryChargingCheckBox.TabIndex = 0;
            this.enableRecordOnBatteryChargingCheckBox.Text = "充電中も記録する";
            // 
            // enableRecordOnPowerConnectingCheckBox
            // 
            this.enableRecordOnPowerConnectingCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.enableRecordOnPowerConnectingCheckBox.ForeColor = System.Drawing.Color.Red;
            this.enableRecordOnPowerConnectingCheckBox.Location = new System.Drawing.Point(3, 74);
            this.enableRecordOnPowerConnectingCheckBox.Name = "enableRecordOnPowerConnectingCheckBox";
            this.enableRecordOnPowerConnectingCheckBox.Size = new System.Drawing.Size(220, 20);
            this.enableRecordOnPowerConnectingCheckBox.TabIndex = 1;
            this.enableRecordOnPowerConnectingCheckBox.Text = "電源接続中も記録する";
            // 
            // recordTimingTabPage
            // 
            this.recordTimingTabPage.Controls.Add(this.panel8);
            this.recordTimingTabPage.Location = new System.Drawing.Point(0, 0);
            this.recordTimingTabPage.Name = "recordTimingTabPage";
            this.recordTimingTabPage.Size = new System.Drawing.Size(240, 245);
            this.recordTimingTabPage.Text = "記録タイミング";
            // 
            // panel8
            // 
            this.panel8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.recordOnIntervalCheckBox);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.recordOnIntervalMinuteComboBox);
            this.panel8.Controls.Add(this.recordOnChangeChargeStateCheckBox);
            this.panel8.Controls.Add(this.recordOnChangeLevelStateCheckBox);
            this.panel8.Location = new System.Drawing.Point(7, 7);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(226, 235);
            // 
            // recordOnIntervalCheckBox
            // 
            this.recordOnIntervalCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordOnIntervalCheckBox.Location = new System.Drawing.Point(3, 35);
            this.recordOnIntervalCheckBox.Name = "recordOnIntervalCheckBox";
            this.recordOnIntervalCheckBox.Size = new System.Drawing.Size(220, 20);
            this.recordOnIntervalCheckBox.TabIndex = 0;
            this.recordOnIntervalCheckBox.Text = "指定した間隔で記録";
            this.recordOnIntervalCheckBox.CheckStateChanged += new System.EventHandler(this.recordOnIntervalCheckBox_CheckStateChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(89, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 16);
            this.label2.Text = "分";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 32);
            this.label1.Text = "下記のタイミングで、自動的にバッテリ残量を記録します。";
            // 
            // recordOnIntervalMinuteComboBox
            // 
            this.recordOnIntervalMinuteComboBox.Items.Add("1");
            this.recordOnIntervalMinuteComboBox.Items.Add("3");
            this.recordOnIntervalMinuteComboBox.Items.Add("5");
            this.recordOnIntervalMinuteComboBox.Items.Add("10");
            this.recordOnIntervalMinuteComboBox.Items.Add("15");
            this.recordOnIntervalMinuteComboBox.Items.Add("30");
            this.recordOnIntervalMinuteComboBox.Items.Add("60");
            this.recordOnIntervalMinuteComboBox.Items.Add("90");
            this.recordOnIntervalMinuteComboBox.Items.Add("120");
            this.recordOnIntervalMinuteComboBox.Location = new System.Drawing.Point(33, 61);
            this.recordOnIntervalMinuteComboBox.Name = "recordOnIntervalMinuteComboBox";
            this.recordOnIntervalMinuteComboBox.Size = new System.Drawing.Size(50, 22);
            this.recordOnIntervalMinuteComboBox.TabIndex = 1;
            // 
            // recordOnChangeChargeStateCheckBox
            // 
            this.recordOnChangeChargeStateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordOnChangeChargeStateCheckBox.ForeColor = System.Drawing.Color.Red;
            this.recordOnChangeChargeStateCheckBox.Location = new System.Drawing.Point(3, 115);
            this.recordOnChangeChargeStateCheckBox.Name = "recordOnChangeChargeStateCheckBox";
            this.recordOnChangeChargeStateCheckBox.Size = new System.Drawing.Size(220, 20);
            this.recordOnChangeChargeStateCheckBox.TabIndex = 3;
            this.recordOnChangeChargeStateCheckBox.Text = "充電状態変化時に記録";
            // 
            // recordOnChangeLevelStateCheckBox
            // 
            this.recordOnChangeLevelStateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.recordOnChangeLevelStateCheckBox.ForeColor = System.Drawing.Color.Red;
            this.recordOnChangeLevelStateCheckBox.Location = new System.Drawing.Point(3, 89);
            this.recordOnChangeLevelStateCheckBox.Name = "recordOnChangeLevelStateCheckBox";
            this.recordOnChangeLevelStateCheckBox.Size = new System.Drawing.Size(220, 20);
            this.recordOnChangeLevelStateCheckBox.TabIndex = 2;
            this.recordOnChangeLevelStateCheckBox.Text = "バッテリレベル変化時に記録";
            // 
            // sendTimingTabPage
            // 
            this.sendTimingTabPage.Controls.Add(this.panel3);
            this.sendTimingTabPage.Location = new System.Drawing.Point(0, 0);
            this.sendTimingTabPage.Name = "sendTimingTabPage";
            this.sendTimingTabPage.Size = new System.Drawing.Size(240, 245);
            this.sendTimingTabPage.Text = "送信タイミング";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.sendOnIntervalCheckBox);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.sendOnCountCheckBox);
            this.panel3.Controls.Add(this.sendOnIntervalMinuteComboBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.sendOnChangeChargeStateCheckBox);
            this.panel3.Controls.Add(this.sendOnCountRecordComboBox);
            this.panel3.Controls.Add(this.sendOnChangeLevelStateCheckBox);
            this.panel3.Location = new System.Drawing.Point(7, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(226, 235);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 32);
            this.label3.Text = "下記のタイミングで、自動的にバッテリ残量をサーバに送信します。";
            // 
            // sendOnIntervalCheckBox
            // 
            this.sendOnIntervalCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendOnIntervalCheckBox.ForeColor = System.Drawing.Color.Red;
            this.sendOnIntervalCheckBox.Location = new System.Drawing.Point(3, 35);
            this.sendOnIntervalCheckBox.Name = "sendOnIntervalCheckBox";
            this.sendOnIntervalCheckBox.Size = new System.Drawing.Size(220, 20);
            this.sendOnIntervalCheckBox.TabIndex = 0;
            this.sendOnIntervalCheckBox.Text = "指定した間隔で送信";
            this.sendOnIntervalCheckBox.CheckStateChanged += new System.EventHandler(this.sendOnIntervalCheckBox_CheckStateChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(89, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 16);
            this.label4.Text = "分";
            // 
            // sendOnCountCheckBox
            // 
            this.sendOnCountCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendOnCountCheckBox.ForeColor = System.Drawing.Color.Red;
            this.sendOnCountCheckBox.Location = new System.Drawing.Point(3, 89);
            this.sendOnCountCheckBox.Name = "sendOnCountCheckBox";
            this.sendOnCountCheckBox.Size = new System.Drawing.Size(220, 20);
            this.sendOnCountCheckBox.TabIndex = 2;
            this.sendOnCountCheckBox.Text = "指定した件数が溜まったら送信";
            this.sendOnCountCheckBox.CheckStateChanged += new System.EventHandler(this.sendOnCountCheckBox_CheckStateChanged);
            // 
            // sendOnIntervalMinuteComboBox
            // 
            this.sendOnIntervalMinuteComboBox.Items.Add("1");
            this.sendOnIntervalMinuteComboBox.Items.Add("3");
            this.sendOnIntervalMinuteComboBox.Items.Add("5");
            this.sendOnIntervalMinuteComboBox.Items.Add("10");
            this.sendOnIntervalMinuteComboBox.Items.Add("15");
            this.sendOnIntervalMinuteComboBox.Items.Add("30");
            this.sendOnIntervalMinuteComboBox.Items.Add("60");
            this.sendOnIntervalMinuteComboBox.Items.Add("90");
            this.sendOnIntervalMinuteComboBox.Items.Add("120");
            this.sendOnIntervalMinuteComboBox.Location = new System.Drawing.Point(33, 61);
            this.sendOnIntervalMinuteComboBox.Name = "sendOnIntervalMinuteComboBox";
            this.sendOnIntervalMinuteComboBox.Size = new System.Drawing.Size(50, 22);
            this.sendOnIntervalMinuteComboBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(89, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 16);
            this.label5.Text = "件";
            // 
            // sendOnChangeChargeStateCheckBox
            // 
            this.sendOnChangeChargeStateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendOnChangeChargeStateCheckBox.ForeColor = System.Drawing.Color.Red;
            this.sendOnChangeChargeStateCheckBox.Location = new System.Drawing.Point(3, 169);
            this.sendOnChangeChargeStateCheckBox.Name = "sendOnChangeChargeStateCheckBox";
            this.sendOnChangeChargeStateCheckBox.Size = new System.Drawing.Size(220, 20);
            this.sendOnChangeChargeStateCheckBox.TabIndex = 5;
            this.sendOnChangeChargeStateCheckBox.Text = "充電状態変化時に送信";
            // 
            // sendOnCountRecordComboBox
            // 
            this.sendOnCountRecordComboBox.Items.Add("1");
            this.sendOnCountRecordComboBox.Items.Add("3");
            this.sendOnCountRecordComboBox.Items.Add("5");
            this.sendOnCountRecordComboBox.Items.Add("10");
            this.sendOnCountRecordComboBox.Items.Add("15");
            this.sendOnCountRecordComboBox.Items.Add("20");
            this.sendOnCountRecordComboBox.Items.Add("30");
            this.sendOnCountRecordComboBox.Location = new System.Drawing.Point(33, 115);
            this.sendOnCountRecordComboBox.Name = "sendOnCountRecordComboBox";
            this.sendOnCountRecordComboBox.Size = new System.Drawing.Size(50, 22);
            this.sendOnCountRecordComboBox.TabIndex = 3;
            // 
            // sendOnChangeLevelStateCheckBox
            // 
            this.sendOnChangeLevelStateCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sendOnChangeLevelStateCheckBox.ForeColor = System.Drawing.Color.Red;
            this.sendOnChangeLevelStateCheckBox.Location = new System.Drawing.Point(3, 143);
            this.sendOnChangeLevelStateCheckBox.Name = "sendOnChangeLevelStateCheckBox";
            this.sendOnChangeLevelStateCheckBox.Size = new System.Drawing.Size(220, 20);
            this.sendOnChangeLevelStateCheckBox.TabIndex = 4;
            this.sendOnChangeLevelStateCheckBox.Text = "バッテリレベル変化時に送信";
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.settingTab);
            this.Menu = this.mainMenu1;
            this.Name = "SettingForm";
            this.Text = "設定";
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.settingTab.ResumeLayout(false);
            this.generalTabPage.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.recordTabPage.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.recordTimingTabPage.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.sendTimingTabPage.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl settingTab;
        private System.Windows.Forms.TabPage recordTimingTabPage;
        private System.Windows.Forms.TabPage sendTimingTabPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox recordOnIntervalMinuteComboBox;
        private System.Windows.Forms.CheckBox recordOnIntervalCheckBox;
        private System.Windows.Forms.CheckBox recordOnChangeLevelStateCheckBox;
        private System.Windows.Forms.CheckBox recordOnChangeChargeStateCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox sendOnIntervalMinuteComboBox;
        private System.Windows.Forms.CheckBox sendOnIntervalCheckBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sendOnCountRecordComboBox;
        private System.Windows.Forms.CheckBox sendOnCountCheckBox;
        private System.Windows.Forms.CheckBox sendOnChangeChargeStateCheckBox;
        private System.Windows.Forms.CheckBox sendOnChangeLevelStateCheckBox;
        private System.Windows.Forms.TabPage generalTabPage;
        private System.Windows.Forms.TextBox deviceTokenTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage recordTabPage;
        private System.Windows.Forms.CheckBox enableRecordOnPowerConnectingCheckBox;
        private System.Windows.Forms.CheckBox enableRecordOnBatteryChargingCheckBox;
        private System.Windows.Forms.Label validTokenLabel;
        private System.Windows.Forms.Label invalidTokenLabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox enableLevelLogCheckBox;
    }
}