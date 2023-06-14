namespace BidHunt.Migrations
{
    public class Asta
    {
        public int Id { get; set; }

        public int fk_offerta { get; set; }

        public DateTime TempoRimanente { get; set; }

        public int Fk_prodotto { get; set; }

        public string Description { get; set; }


    }
}
