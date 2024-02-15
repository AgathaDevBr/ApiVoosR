using Newtonsoft.Json;

namespace ApiVoos.Service.Models
{
    public class CompanhiasAreas
    {
        [JsonProperty("FlightNumber")]
        public string? voo {  get; set; }

        [JsonProperty("Carrier")]
        public string? companhia { get; set; }

        [JsonProperty("OriginAirport")]
        public string? origem { get; set; }

        [JsonProperty("DestinationAirport")]
        public string? destino { get; set; }

        [JsonProperty("DepartureDate")]
        public DateTime? partida { get; set; }

        [JsonProperty("ArrivalDate")]
        public DateTime? chegada { get; set; }

        [JsonProperty("FarePrice")]
        public double? tarifa { get; set; }
    }
}
