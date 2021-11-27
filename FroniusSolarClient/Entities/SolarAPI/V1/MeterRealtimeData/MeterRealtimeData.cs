using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace FroniusSolarClient.Entities.SolarAPI.V1.MeterRealtimeData
{
    public class MeterRealtimeData
    {
        [JsonProperty("Current_AC_Phase_1")]
        public decimal CurrentACPhase1 { get; set; }

        [JsonProperty("Current_AC_Phase_2")]
        public decimal CurrentACPhase2 { get; set; }

        [JsonProperty("Current_AC_Phase_3")]
        public decimal CurrentACPhase3 { get; set; }

        [JsonProperty("EnergyReal_WAC_Sum_Consumed")]
        public decimal EnergyRealWACSumConsumed { get; set; }

        [JsonProperty("TimeStamp")]
        public long TimeStamp { get; set; }

        [JsonProperty("Details")]
        public MeterDetails Details { get; set; }
    }
}
