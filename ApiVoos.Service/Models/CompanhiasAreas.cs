namespace ApiVoos.Service.Models
{
    public class CompanhiasAreas
    {

        public string? voo {  get; set; }
        public string? companhia { get; set; }
        public string? origem { get; set; }
        public string? destino { get; set; }
        public DateTime? partida { get; set; }
        public DateTime? chegada { get; set; }
        public double? tarifa { get; set; }
    }
}
