using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LiteDB;
using Wiser.DataObjects;
using System.IO;

namespace WiserMonitor
{
    public class DataLogger
    {
        private string GetDBPath()
        {
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "WiserData.ldb");
        }
        public void WriteValveData(HeatHub hub)
        {
            try
            {
                using (var logDB = new LiteDatabase(GetDBPath()))
                {
                    var valveData = logDB.GetCollection<SmartValveData>();
                    var plugData = logDB.GetCollection<SmartplugData>();

                    foreach (var device in hub.Device)
                    {
                        if (device.ProductType == "iTRV")
                        {
                            var newData = new SmartValveData
                            {
                                DeviceID = device.id,
                                DataDate = DateTime.Now,
                                BatteryLevel = device.BatteryLevel,
                                BatteryVoltage = (int)device.BatteryVoltage,
                                DisplayedSignalStrength = device.DisplayedSignalStrength,
                                DeviceLQI = device.ReceptionOfDevice.Lqi,
                                DeviceRSSI = device.ReceptionOfDevice.Rssi
                            };
                            valveData.Insert(newData);
                        }
                        else if (device.ProductType == "SmartPlug")
                        {
                            var newData = new SmartplugData
                            {
                                DeviceID = device.id,
                                DataDate = DateTime.Now,
                                ManufacturerName = device.ProductIdentifier,
                                ModelName = device.ModelIdentifier,
                                //OutputState = device.OutputState,
                                DisplayedSignalStrength = device.DisplayedSignalStrength,
                                DeviceLQI = device.ReceptionOfDevice.Lqi,
                                DeviceRSSI = device.ReceptionOfDevice.Rssi
                            };
                            plugData.Insert(newData);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }
        }


        public void WriteRoomData(HeatHub hub)
        {
            try
            {
                using (var logDB = new LiteDatabase(GetDBPath()))
                {
                    var roomData = logDB.GetCollection<RoomData>();

                    foreach (var room in hub.Room)
                    {
                        var newData = new RoomData
                        {
                            id = room.id,
                            DataDate = DateTime.Now,
                            Name = room.Name,
                            CalculatedTemperature = room.CalculatedTemperature,
                            CurrentSetPoint = room.CurrentSetPoint,
                            PercentageDemand = room.PercentageDemand
                        };
                        roomData.Insert(newData);
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<RoomData> GetRoomData(string roomName, DateTime startDate, DateTime endDate)
        {
            List<RoomData> data = null;
            using (var logDB = new LiteDatabase(GetDBPath()))
            {
                var roomData = logDB.GetCollection<RoomData>();
                data = roomData.FindAll().Where(t => t.Name == roomName && t.DataDate >= startDate && t.DataDate <= endDate).OrderBy(t => t.DataDate).ToList<RoomData>();
            }
            return data;
        }

        public void ExportCSV()
        {
            StringBuilder csvOutput;
            string csvFilePath; 

            using (var logDB = new LiteDatabase(GetDBPath()))
            {
                csvOutput = new StringBuilder("Date,DeviceId,Battery Level,BatteryVoltage,Displayed Signal Strength,LQI,RSSI\n");
                var valveData = logDB.GetCollection<SmartValveData>();
                foreach (var valve in valveData.FindAll())
                {
                    StringBuilder dataText = new StringBuilder(string.Format("{0},", valve.DataDate));
                    dataText.AppendFormat(string.Format("{0},", valve.DeviceID));
                    dataText.AppendFormat(string.Format("{0},", valve.BatteryLevel));
                    dataText.AppendFormat(string.Format("{0},", valve.BatteryVoltage));
                    dataText.AppendFormat(string.Format("{0},", valve.DisplayedSignalStrength));
                    dataText.AppendFormat(string.Format("{0},", valve.DeviceLQI));
                    dataText.AppendFormat(string.Format("{0}", valve.DeviceRSSI));
                    csvOutput.AppendLine(dataText.ToString());
                }
                csvFilePath = string.Format("{0}_{1}.csv", "SmartValveData", DateTime.Now.ToString("yyyyMMddHHmmss"));
                File.WriteAllText(csvFilePath, csvOutput.ToString());

                csvOutput = new StringBuilder("Date,Room,Current Temp,Set Temp,Percentage Demand\n");

                var roomData = logDB.GetCollection<RoomData>();
                foreach (var room in roomData.FindAll())
                {
                    StringBuilder dataText = new StringBuilder(string.Format("{0},", room.DataDate));
                    //dataText.AppendFormat(string.Format("{0},", room.id));
                    dataText.AppendFormat(string.Format("{0},", room.Name));
                    dataText.AppendFormat(string.Format("{0},", ((double)room.CalculatedTemperature)/10));
                    dataText.AppendFormat(string.Format("{0},", ((double)room.CurrentSetPoint)/10));
                    dataText.AppendFormat(string.Format("{0},", room.PercentageDemand));
                    csvOutput.AppendLine(dataText.ToString());
                }
                csvFilePath = string.Format("{0}_{1}.csv", "RoomData", DateTime.Now.ToString("yyyyMMddHHmmss"));
                File.WriteAllText(csvFilePath, csvOutput.ToString());


            }
        }
    }
}
