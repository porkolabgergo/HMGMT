using System.Text.Json.Serialization;

namespace HMGMT.Shared.Models;

public class ThermostatModel
{
    [JsonPropertyName("date/time")] public string DateTime { get; set; }

    [JsonPropertyName("floor drying")] public string FloorDrying { get; set; }

    [JsonPropertyName("damped outdoor temperature")]
    public double DampedOutdoorTemperature { get; set; }

    [JsonPropertyName("floor drying temperature")]
    public int FloorDryingTemperature { get; set; }

    [JsonPropertyName("building type")] public string BuildingType { get; set; }

    [JsonPropertyName("minimal external temperature")]
    public int MinimalExternalTemperature { get; set; }

    [JsonPropertyName("damping outdoor temperature")]
    public string DampingOutdoorTemperature { get; set; }

    [JsonPropertyName("dhw mode")] public string DhwMode { get; set; }

    [JsonPropertyName("dhw circulation pump mode")]
    public string DhwCirculationPumpMode { get; set; }

    [JsonPropertyName("dhw charge duration")]
    public int DhwChargeDuration { get; set; }

    [JsonPropertyName("dhw charge")] public string DhwCharge { get; set; }

    [JsonPropertyName("dhw disinfecting")] public string DhwDisinfecting { get; set; }

    [JsonPropertyName("dhw disinfection day")]
    public string DhwDisinfectionDay { get; set; }

    [JsonPropertyName("dhw disinfection time")]
    public int DhwDisinfectionTime { get; set; }

    [JsonPropertyName("hc1 selected room temperature")]
    public int Hc1SelectedRoomTemperature { get; set; }

    [JsonPropertyName("hc1 mode")] public string Hc1Mode { get; set; }

    [JsonPropertyName("hc1 mode type")] public string Hc1ModeType { get; set; }

    [JsonPropertyName("hc1 eco temperature")]
    public int Hc1EcoTemperature { get; set; }

    [JsonPropertyName("hc1 manual temperature")]
    public int Hc1ManualTemperature { get; set; }

    [JsonPropertyName("hc1 comfort temperature")]
    public double Hc1ComfortTemperature { get; set; }

    [JsonPropertyName("hc1 summer temperature")]
    public int Hc1SummerTemperature { get; set; }

    [JsonPropertyName("hc1 design temperature")]
    public int Hc1DesignTemperature { get; set; }

    [JsonPropertyName("hc1 offset temperature")]
    public int Hc1OffsetTemperature { get; set; }

    [JsonPropertyName("hc1 min flow temperature")]
    public int Hc1MinFlowTemperature { get; set; }

    [JsonPropertyName("hc1 max flow temperature")]
    public int Hc1MaxFlowTemperature { get; set; }

    [JsonPropertyName("hc1 room influence")]
    public int Hc1RoomInfluence { get; set; }

    [JsonPropertyName("hc1 room influence factor")]
    public int Hc1RoomInfluenceFactor { get; set; }

    [JsonPropertyName("hc1 current room influence")]
    public int Hc1CurrentRoomInfluence { get; set; }

    [JsonPropertyName("hc1 nofrost mode")] public string Hc1NofrostMode { get; set; }

    [JsonPropertyName("hc1 nofrost temperature")]
    public int Hc1NofrostTemperature { get; set; }

    [JsonPropertyName("hc1 target flow temperature")]
    public int Hc1TargetFlowTemperature { get; set; }

    [JsonPropertyName("hc1 heating type")] public string Hc1HeatingType { get; set; }

    [JsonPropertyName("hc1 set summer mode")]
    public string Hc1SetSummerMode { get; set; }

    [JsonPropertyName("hc1 summer mode")] public string Hc1SummerMode { get; set; }

    [JsonPropertyName("hc1 control mode")] public string Hc1ControlMode { get; set; }

    [JsonPropertyName("hc1 program")] public string Hc1Program { get; set; }

    [JsonPropertyName("hc1 temporary set temperature automode")]
    public int Hc1TemporarySetTemperatureAutomode { get; set; }

    [JsonPropertyName("hc1 temporary set temperature from remote")]
    public int Hc1TemporarySetTemperatureFromRemote { get; set; }

    [JsonPropertyName("hc1 fast heatup")] public int Hc1FastHeatup { get; set; }

    [JsonPropertyName("hc1 switch-on optimization")]
    public string Hc1SwitchOnOptimization { get; set; }

    [JsonPropertyName("hc1 reduce mode")] public string Hc1ReduceMode { get; set; }

    [JsonPropertyName("hc1 no reduce below temperature")]
    public int Hc1NoReduceBelowTemperature { get; set; }

    [JsonPropertyName("hc1 off/reduce switch temperature")]
    public int Hc1OffReduceSwitchTemperature { get; set; }

    [JsonPropertyName("hc1 dhw priority")] public string Hc1DhwPriority { get; set; }

    [JsonPropertyName("hc2 selected room temperature")]
    public int Hc2SelectedRoomTemperature { get; set; }

    [JsonPropertyName("hc2 mode")] public string Hc2Mode { get; set; }

    [JsonPropertyName("hc2 mode type")] public string Hc2ModeType { get; set; }

    [JsonPropertyName("hc2 eco temperature")]
    public int Hc2EcoTemperature { get; set; }

    [JsonPropertyName("hc2 manual temperature")]
    public int Hc2ManualTemperature { get; set; }

    [JsonPropertyName("hc2 comfort temperature")]
    public double Hc2ComfortTemperature { get; set; }

    [JsonPropertyName("hc2 summer temperature")]
    public int Hc2SummerTemperature { get; set; }

    [JsonPropertyName("hc2 design temperature")]
    public int Hc2DesignTemperature { get; set; }

    [JsonPropertyName("hc2 offset temperature")]
    public int Hc2OffsetTemperature { get; set; }

    [JsonPropertyName("hc2 min flow temperature")]
    public int Hc2MinFlowTemperature { get; set; }

    [JsonPropertyName("hc2 max flow temperature")]
    public int Hc2MaxFlowTemperature { get; set; }

    [JsonPropertyName("hc2 room influence")]
    public int Hc2RoomInfluence { get; set; }

    [JsonPropertyName("hc2 room influence factor")]
    public int Hc2RoomInfluenceFactor { get; set; }

    [JsonPropertyName("hc2 current room influence")]
    public int Hc2CurrentRoomInfluence { get; set; }

    [JsonPropertyName("hc2 nofrost mode")] public string Hc2NofrostMode { get; set; }

    [JsonPropertyName("hc2 nofrost temperature")]
    public int Hc2NofrostTemperature { get; set; }

    [JsonPropertyName("hc2 target flow temperature")]
    public int Hc2TargetFlowTemperature { get; set; }

    [JsonPropertyName("hc2 heating type")] public string Hc2HeatingType { get; set; }

    [JsonPropertyName("hc2 set summer mode")]
    public string Hc2SetSummerMode { get; set; }

    [JsonPropertyName("hc2 summer mode")] public string Hc2SummerMode { get; set; }

    [JsonPropertyName("hc2 control mode")] public string Hc2ControlMode { get; set; }

    [JsonPropertyName("hc2 program")] public string Hc2Program { get; set; }

    [JsonPropertyName("hc2 temporary set temperature automode")]
    public int Hc2TemporarySetTemperatureAutomode { get; set; }

    [JsonPropertyName("hc2 temporary set temperature from remote")]
    public int Hc2TemporarySetTemperatureFromRemote { get; set; }

    [JsonPropertyName("hc2 fast heatup")] public int Hc2FastHeatup { get; set; }

    [JsonPropertyName("hc2 switch-on optimization")]
    public string Hc2SwitchOnOptimization { get; set; }

    [JsonPropertyName("hc2 reduce mode")] public string Hc2ReduceMode { get; set; }

    [JsonPropertyName("hc2 no reduce below temperature")]
    public int Hc2NoReduceBelowTemperature { get; set; }

    [JsonPropertyName("hc2 off/reduce switch temperature")]
    public int Hc2OffReduceSwitchTemperature { get; set; }

    [JsonPropertyName("hc2 dhw priority")] public string Hc2DhwPriority { get; set; }

    [JsonPropertyName("hc3 selected room temperature")]
    public int Hc3SelectedRoomTemperature { get; set; }

    [JsonPropertyName("hc3 mode")] public string Hc3Mode { get; set; }

    [JsonPropertyName("hc3 mode type")] public string Hc3ModeType { get; set; }

    [JsonPropertyName("hc3 eco temperature")]
    public int Hc3EcoTemperature { get; set; }

    [JsonPropertyName("hc3 manual temperature")]
    public int Hc3ManualTemperature { get; set; }

    [JsonPropertyName("hc3 comfort temperature")]
    public double Hc3ComfortTemperature { get; set; }

    [JsonPropertyName("hc3 summer temperature")]
    public int Hc3SummerTemperature { get; set; }

    [JsonPropertyName("hc3 design temperature")]
    public int Hc3DesignTemperature { get; set; }

    [JsonPropertyName("hc3 offset temperature")]
    public int Hc3OffsetTemperature { get; set; }

    [JsonPropertyName("hc3 min flow temperature")]
    public int Hc3MinFlowTemperature { get; set; }

    [JsonPropertyName("hc3 max flow temperature")]
    public int Hc3MaxFlowTemperature { get; set; }

    [JsonPropertyName("hc3 room influence")]
    public int Hc3RoomInfluence { get; set; }

    [JsonPropertyName("hc3 room influence factor")]
    public int Hc3RoomInfluenceFactor { get; set; }

    [JsonPropertyName("hc3 current room influence")]
    public int Hc3CurrentRoomInfluence { get; set; }

    [JsonPropertyName("hc3 nofrost mode")] public string Hc3NofrostMode { get; set; }

    [JsonPropertyName("hc3 nofrost temperature")]
    public int Hc3NofrostTemperature { get; set; }

    [JsonPropertyName("hc3 target flow temperature")]
    public int Hc3TargetFlowTemperature { get; set; }

    [JsonPropertyName("hc3 heating type")] public string Hc3HeatingType { get; set; }

    [JsonPropertyName("hc3 set summer mode")]
    public string Hc3SetSummerMode { get; set; }

    [JsonPropertyName("hc3 summer mode")] public string Hc3SummerMode { get; set; }

    [JsonPropertyName("hc3 control mode")] public string Hc3ControlMode { get; set; }

    [JsonPropertyName("hc3 program")] public string Hc3Program { get; set; }

    [JsonPropertyName("hc3 temporary set temperature automode")]
    public int Hc3TemporarySetTemperatureAutomode { get; set; }

    [JsonPropertyName("hc3 temporary set temperature from remote")]
    public int Hc3TemporarySetTemperatureFromRemote { get; set; }

    [JsonPropertyName("hc3 fast heatup")] public int Hc3FastHeatup { get; set; }

    [JsonPropertyName("hc3 switch-on optimization")]
    public string Hc3SwitchOnOptimization { get; set; }

    [JsonPropertyName("hc3 reduce mode")] public string Hc3ReduceMode { get; set; }

    [JsonPropertyName("hc3 no reduce below temperature")]
    public int Hc3NoReduceBelowTemperature { get; set; }

    [JsonPropertyName("hc3 off/reduce switch temperature")]
    public int Hc3OffReduceSwitchTemperature { get; set; }

    [JsonPropertyName("hc3 dhw priority")] public string Hc3DhwPriority { get; set; }
}