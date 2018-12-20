using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WiserMonitor
{
    public class SmartValveData
    {
        public Guid Id { get; set; }
        public int DeviceID {get;set;}
        public DateTime DataDate { get; set; }
        public string BatteryLevel { get; set; }
        public int BatteryVoltage { get; set; }
        public string DisplayedSignalStrength { get; set; }
        public int DeviceLQI { get; set; }
        public int DeviceRSSI { get; set; }
    }

    public class RoomData
    {
        public Guid Id { get; set; }
        public int id { get; set; }
        public DateTime DataDate { get; set; }
        public string Name { get; set; }
        public int CalculatedTemperature { get; set; }
        public int CurrentSetPoint { get; set; }
        public int PercentageDemand { get; set; }
    }
}
