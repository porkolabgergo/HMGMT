using System.Text.Json.Serialization;

namespace HMGMT.Shared.Models;

public class MixerModel
{
        [JsonPropertyName("flowtemphc")]
        public double FlowTempHc { get; set; }
        
        [JsonPropertyName("valvestatus")]
        public int ValveStatus { get; set; }

        [JsonPropertyName("flowsettemp")]
        public int FlowSetTemp { get; set; }

        [JsonPropertyName("pumpstatus")]
        public string PumpStatus { get; set; }
}