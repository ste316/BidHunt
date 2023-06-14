namespace BidHunt.Models
{
    public class MetodoPagamento
    {
        public int Id { get; set; }
        public string Tipo { get; set; }
        public string Numero_carta { get; set; }
        public int Mese_scadenza { get; set; }
        public int Anno_scadenza { get; set; }
    }
}

/*

 */