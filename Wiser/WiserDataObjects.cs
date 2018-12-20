using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Wiser.DataObjects
{

    public class BoilerSettings
    {
        public string ControlType { get; set; }
        public string FuelType { get; set; }
        public string CycleRate { get; set; }
        public int OnOffHysteresis { get; set; }
    }

    public class ZigbeeSettings
    {
        public bool SuppressApsAcks { get; set; }
    }

    public class LocalDateAndTime
    {
        public int Year { get; set; }
        public string Month { get; set; }
        public int Date { get; set; }
        public string Day { get; set; }
        public int Time { get; set; }
    }

    public class System
    {
        public string PairingStatus { get; set; }
        public string OverrideType { get; set; }
        public int TimeZoneOffset { get; set; }
        public bool AutomaticDaylightSaving { get; set; }
        public string SystemMode { get; set; }
        public int Version { get; set; }
        public bool FotaEnabled { get; set; }
        public bool ValveProtectionEnabled { get; set; }
        public bool EcoModeEnabled { get; set; }
        public bool AwayModeAffectsHotWater { get; set; }
        public int AwayModeSetPointLimit { get; set; }
        public BoilerSettings BoilerSettings { get; set; }
        public ZigbeeSettings ZigbeeSettings { get; set; }
        public int CoolingModeDefaultSetpoint { get; set; }
        public int CoolingAwayModeSetpointLimit { get; set; }
        public bool ComfortModeEnabled { get; set; }
        public int PreheatTimeLimit { get; set; }
        public int DegradedModeSetpointThreshold { get; set; }
        public int UnixTime { get; set; }
        public string ActiveSystemVersion { get; set; }
        public bool ZigbeePermitJoinActive { get; set; }
        public string CloudConnectionStatus { get; set; }
        public string ZigbeeModuleVersion { get; set; }
        public string ZigbeeEui { get; set; }
        public LocalDateAndTime LocalDateAndTime { get; set; }
        public string HeatingButtonOverrideState { get; set; }
        public string HotWaterButtonOverrideState { get; set; }
    }

    public class Cloud
    {
        public string Environment { get; set; }
        public bool DetailedPublishing { get; set; }
        public string WiserApiHost { get; set; }
        public string BootStrapApiHost { get; set; }
    }

    public class HeatingChannel
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<int> RoomIds { get; set; }
        public int PercentageDemand { get; set; }
        public string DemandOnOffOutput { get; set; }
        public string HeatingRelayState { get; set; }
        public bool IsSmartValvePreventingDemand { get; set; }
    }

    public class HotWater
    {
        public int id { get; set; }
        public string OverrideWaterHeatingState { get; set; }
        public int ScheduleId { get; set; }
        public string Mode { get; set; }
        public string WaterHeatingState { get; set; }
        public string ScheduledWaterHeatingState { get; set; }
        public string HotWaterRelayState { get; set; }
        public string HotWaterDescription { get; set; }
    }

    public class Room
    {
        public int id { get; set; }
        public int ManualSetPoint { get; set; }
        public string OverrideType { get; set; }
        public int OverrideSetpoint { get; set; }
        public long OverrideTimeoutUnixTime { get; set; }
        public int ScheduleId { get; set; }
        public int ComfortModeScore { get; set; }
        public int HeatingRate { get; set; }
        public int RoomStatId { get; set; }
        public List<int> SmartValveIds { get; set; }
        public string Name { get; set; }
        public string Mode { get; set; }
        public string DemandType { get; set; }
        public bool WindowDetectionActive { get; set; }
        public string ControlSequenceOfOperation { get; set; }
        public string HeatingType { get; set; }
        public int CalculatedTemperature { get; set; }
        public int CurrentSetPoint { get; set; }
        public int PercentageDemand { get; set; }
        public string ControlOutputState { get; set; }
        public string WindowState { get; set; }
        public string SetPointOrigin { get; set; }
        public int DisplayedSetPoint { get; set; }
        public int ScheduledSetPoint { get; set; }
        public bool AwayModeSuppressed { get; set; }
        public int RoundedAlexaTemperature { get; set; }
        public List<object> UfhRelayIds { get; set; }
        public int? ComfortTarget { get; set; }
    }

    public class ReceptionOfController
    {
        public int Rssi { get; set; }
        public int? Lqi { get; set; }
    }

    public class ReceptionOfDevice
    {
        public int Rssi { get; set; }
        public int Lqi { get; set; }
    }

    public class Device
    {
        public int id { get; set; }
        public int NodeId { get; set; }
        public string ProductType { get; set; }
        public string ProductIdentifier { get; set; }
        public string ActiveFirmwareVersion { get; set; }
        public string ModelIdentifier { get; set; }
        public bool DeviceLockEnabled { get; set; }
        public string DisplayedSignalStrength { get; set; }
        public ReceptionOfController ReceptionOfController { get; set; }
        public ReceptionOfDevice ReceptionOfDevice { get; set; }
        public int PendingZigbeeMessageMask { get; set; }
        public string HardwareVersion { get; set; }
        public string SerialNumber { get; set; }
        public string ProductModel { get; set; }
        public int? OtaImageQueryCount { get; set; }
        public int? LastOtaImageQueryCount { get; set; }
        public int? ParentNodeId { get; set; }
        public int? BatteryVoltage { get; set; }
        public string BatteryLevel { get; set; }
        public bool? IdentifyActive { get; set; }
        public int? OtaLastImageSentBytes { get; set; }
    }

    public class UpgradeInfo
    {
        public int id { get; set; }
        public string FirmwareFilename { get; set; }
    }

    public class SmartValve
    {
        public int id { get; set; }
        public string MountingOrientation { get; set; }
        public int SetPoint { get; set; }
        public int MeasuredTemperature { get; set; }
        public int PercentageDemand { get; set; }
        public string WindowState { get; set; }
        public int ExternalRoomStatTemperature { get; set; }
    }

    public class RoomStat
    {
        public int id { get; set; }
        public int SetPoint { get; set; }
        public int MeasuredTemperature { get; set; }
        public int MeasuredHumidity { get; set; }
    }

    public class SmartPlug
    {
        public int id { get; set; }
        public int ScheduleId { get; set; }
        public string ManualState { get; set; }
        public string Name { get; set; }
        public string Mode { get; set; }
        public string AwayAction { get; set; }
        public string OutputState { get; set; }
        public string ControlSource { get; set; }
        public string ScheduledState { get; set; }
    }

    public class DeviceCapabilityMatrix
    {
        public bool Roomstat { get; set; }
        public bool ITRV { get; set; }
        public bool SmartPlug { get; set; }
        public bool UFH { get; set; }
        public bool UFHFloorTempSensor { get; set; }
        public bool UFHDewSensor { get; set; }
        public bool HACT { get; set; }
        public bool LACT { get; set; }
    }

    public class SetPoint
    {
        public int Time { get; set; }
        public int DegreesC { get; set; }
    }

    public class Monday
    {
        public List<SetPoint> SetPoints { get; set; }
    }

    public class SetPoint2
    {
        public int Time { get; set; }
        public int DegreesC { get; set; }
    }

    public class Tuesday
    {
        public List<SetPoint2> SetPoints { get; set; }
    }

    public class SetPoint3
    {
        public int Time { get; set; }
        public int DegreesC { get; set; }
    }

    public class Wednesday
    {
        public List<SetPoint3> SetPoints { get; set; }
    }

    public class SetPoint4
    {
        public int Time { get; set; }
        public int DegreesC { get; set; }
    }

    public class Thursday
    {
        public List<SetPoint4> SetPoints { get; set; }
    }

    public class SetPoint5
    {
        public int Time { get; set; }
        public int DegreesC { get; set; }
    }

    public class Friday
    {
        public List<SetPoint5> SetPoints { get; set; }
    }

    public class SetPoint6
    {
        public int Time { get; set; }
        public int DegreesC { get; set; }
    }

    public class Saturday
    {
        public List<SetPoint6> SetPoints { get; set; }
    }

    public class SetPoint7
    {
        public int Time { get; set; }
        public int DegreesC { get; set; }
    }

    public class Sunday
    {
        public List<SetPoint7> SetPoints { get; set; }
    }

    public class Schedule
    {
        public int id { get; set; }
        public Monday Monday { get; set; }
        public Tuesday Tuesday { get; set; }
        public Wednesday Wednesday { get; set; }
        public Thursday Thursday { get; set; }
        public Friday Friday { get; set; }
        public Saturday Saturday { get; set; }
        public Sunday Sunday { get; set; }
        public string Type { get; set; }
    }

    public class RootObject
    {
        public System System { get; set; }
        public Cloud Cloud { get; set; }
        public List<HeatingChannel> HeatingChannel { get; set; }
        public List<HotWater> HotWater { get; set; }
        public List<Room> Room { get; set; }
        public List<Device> Device { get; set; }
        public List<UpgradeInfo> UpgradeInfo { get; set; }
        public List<SmartValve> SmartValve { get; set; }
        public List<RoomStat> RoomStat { get; set; }
        public List<SmartPlug> SmartPlug { get; set; }
        public DeviceCapabilityMatrix DeviceCapabilityMatrix { get; set; }
        public List<Schedule> Schedule { get; set; }
    }

    public class HeatHub : RootObject { }
}
