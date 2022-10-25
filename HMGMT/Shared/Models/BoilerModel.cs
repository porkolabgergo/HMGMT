using System.Text.Json.Serialization;

namespace HMGMT.Shared.Models;

public class BoilerModel
{
    [JsonPropertyName("heating active")] public string HeatingActive { get; set; }

    [JsonPropertyName("tapwater active")] public string TapwaterActive { get; set; }

    [JsonPropertyName("selected flow temperature")]
    public int SelectedFlowTemperature { get; set; }

    [JsonPropertyName("burner selected max power")]
    public int BurnerSelectedMaxPower { get; set; }

    [JsonPropertyName("heating pump modulation")]
    public int HeatingPumpModulation { get; set; }

    [JsonPropertyName("heating pump 2 modulation")]
    public int HeatingPump2Modulation { get; set; }

    [JsonPropertyName("outside temperature")]
    public double OutsideTemperature { get; set; }

    [JsonPropertyName("current flow temperature")]
    public double CurrentFlowTemperature { get; set; }

    [JsonPropertyName("exhaust temperature")]
    public int ExhaustTemperature { get; set; }

    [JsonPropertyName("gas")] public string Gas { get; set; }

    [JsonPropertyName("flame current")] public int FlameCurrent { get; set; }

    [JsonPropertyName("heating pump")] public string HeatingPump { get; set; }

    [JsonPropertyName("fan")] public string Fan { get; set; }

    [JsonPropertyName("ignition")] public string Ignition { get; set; }

    [JsonPropertyName("heating activated")]
    public string HeatingActivated { get; set; }

    [JsonPropertyName("heating temperature")]
    public int HeatingTemperature { get; set; }

    [JsonPropertyName("burner min period")]
    public int BurnerMinPeriod { get; set; }

    [JsonPropertyName("burner min power")] public int BurnerMinPower { get; set; }

    [JsonPropertyName("burner max power")] public int BurnerMaxPower { get; set; }

    [JsonPropertyName("hysteresis on temperature")]
    public int HysteresisOnTemperature { get; set; }

    [JsonPropertyName("hysteresis off temperature")]
    public int HysteresisOffTemperature { get; set; }

    [JsonPropertyName("burner current power")]
    public int BurnerCurrentPower { get; set; }

    [JsonPropertyName("burner starts")] public int BurnerStarts { get; set; }

    [JsonPropertyName("total burner operating time")]
    public string TotalBurnerOperatingTime { get; set; }

    [JsonPropertyName("burner stage 2 operating time")]
    public string BurnerStage2OperatingTime { get; set; }

    [JsonPropertyName("total heat operating time")]
    public string TotalHeatOperatingTime { get; set; }

    [JsonPropertyName("total UBA operating time")]
    public string TotalUBAOperatingTime { get; set; }

    [JsonPropertyName("last error code")] public string LastErrorCode { get; set; }

    [JsonPropertyName("service code")] public string ServiceCode { get; set; }

    [JsonPropertyName("service code number")]
    public int ServiceCodeNumber { get; set; }

    [JsonPropertyName("maintenance message")]
    public string MaintenanceMessage { get; set; }

    [JsonPropertyName("maintenance scheduled")]
    public string MaintenanceScheduled { get; set; }

    [JsonPropertyName("time to next maintenance")]
    public int TimeToNextMaintenance { get; set; }

    [JsonPropertyName("emergency operation")]
    public string EmergencyOperation { get; set; }

    [JsonPropertyName("emergency temperature")]
    public int EmergencyTemperature { get; set; }

    [JsonPropertyName("dhw set temperature")]
    public int DhwSetTemperature { get; set; }

    [JsonPropertyName("dhw selected temperature")]
    public int DhwSelectedTemperature { get; set; }

    [JsonPropertyName("dhw selected lower temperature")]
    public int DhwSelectedLowerTemperature { get; set; }

    [JsonPropertyName("dhw selected temperature for off")]
    public int DhwSelectedTemperatureForOff { get; set; }

    [JsonPropertyName("dhw single charge temperature")]
    public int DhwSingleChargeTemperature { get; set; }

    [JsonPropertyName("dhw comfort mode")] public string DhwComfortMode { get; set; }

    [JsonPropertyName("dhw flow temperature offset")]
    public int DhwFlowTemperatureOffset { get; set; }

    [JsonPropertyName("dhw charge optimization")]
    public string DhwChargeOptimization { get; set; }

    [JsonPropertyName("dhw maximum temperature")]
    public int DhwMaximumTemperature { get; set; }

    [JsonPropertyName("dhw circulation pump available")]
    public string DhwCirculationPumpAvailable { get; set; }

    [JsonPropertyName("dhw hysteresis on temperature")]
    public int DhwHysteresisOnTemperature { get; set; }

    [JsonPropertyName("dhw hysteresis off temperature")]
    public int DhwHysteresisOffTemperature { get; set; }

    [JsonPropertyName("dhw disinfection temperature")]
    public int DhwDisinfectionTemperature { get; set; }

    [JsonPropertyName("dhw circulation pump mode")]
    public string DhwCirculationPumpMode { get; set; }

    [JsonPropertyName("dhw circulation active")]
    public string DhwCirculationActive { get; set; }

    [JsonPropertyName("dhw activated")] public string DhwActivated { get; set; }

    [JsonPropertyName("dhw one time charging")]
    public string DhwOneTimeCharging { get; set; }

    [JsonPropertyName("dhw disinfecting")] public string DhwDisinfecting { get; set; }

    [JsonPropertyName("dhw charging")] public string DhwCharging { get; set; }

    [JsonPropertyName("dhw recharging")] public string DhwRecharging { get; set; }

    [JsonPropertyName("dhw temperature ok")]
    public string DhwTemperatureOk { get; set; }

    [JsonPropertyName("dhw 3way valve active")]
    public string Dhw3wayValveActive { get; set; }

    [JsonPropertyName("dhw starts")] public int DhwStarts { get; set; }

    [JsonPropertyName("dhw active time")] public string DhwActiveTime { get; set; }
}