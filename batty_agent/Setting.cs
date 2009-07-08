﻿
using System;
using System.Collections.Generic;
using System.Text;

namespace nayutaya.batty.agent
{
    public class Setting
    {
        private String deviceToken;
        private bool enableRecordOnBatteryCharging;
        private bool enableRecordOnPowerConnecting;
        private bool enableLevelLog;
        private bool recordOnInterval;
        private uint recordOnIntervalMinute;
        private bool recordOnChangeLevelState;
        private bool recordOnChangeChargeState;
        private bool sendOnInterval;
        private uint sendOnIntervalMinute;
        private bool sendOnCount;
        private uint sendOnCountRecord;
        private bool sendOnChangeLevelState;
        private bool sendOnChangeChargeState;

        public String DeviceToken
        {
            get { return deviceToken; }
            set { deviceToken = value; }
        }

        public bool EnableRecordOnBatteryCharging
        {
            get { return enableRecordOnBatteryCharging; }
            set { enableRecordOnBatteryCharging = value; }
        }

        public bool EnableRecordOnPowerConnecting
        {
            get { return enableRecordOnPowerConnecting; }
            set { enableRecordOnPowerConnecting = value; }
        }

        public bool EnableLevelLog
        {
            get { return enableLevelLog; }
            set { enableLevelLog = value; }
        }

        public bool RecordOnInterval
        {
            get { return recordOnInterval; }
            set { recordOnInterval = value; }
        }

        public uint RecordOnIntervalMinute
        {
            get { return recordOnIntervalMinute; }
            set { recordOnIntervalMinute = value; }
        }

        public bool RecordOnChangeLevelState
        {
            get { return recordOnChangeLevelState; }
            set { recordOnChangeLevelState = value; }
        }

        public bool RecordOnChangeChargeState
        {
            get { return recordOnChangeChargeState; }
            set { recordOnChangeChargeState = value; }
        }

        public bool SendOnInterval
        {
            get { return sendOnInterval; }
            set { sendOnInterval = value; }
        }

        public uint SendOnIntervalMinute
        {
            get { return sendOnIntervalMinute; }
            set { sendOnIntervalMinute = value; }
        }

        public bool SendOnCount
        {
            get { return sendOnCount; }
            set { sendOnCount = value; }
        }

        public uint SendOnCountRecord
        {
            get { return sendOnCountRecord; }
            set { sendOnCountRecord = value; }
        }

        public bool SendOnChangeLevelState
        {
            get { return sendOnChangeLevelState; }
            set { sendOnChangeLevelState = value; }
        }

        public bool SendOnChangeChargeState
        {
            get { return sendOnChangeChargeState; }
            set { sendOnChangeChargeState = value; }
        }
    }
}
