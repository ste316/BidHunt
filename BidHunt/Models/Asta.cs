namespace BidHunt.Migrations
{
    public class Asta
    {
        public int Id { get; set; }

        public int fk_offerta { get; set; }

        public int TempoRimanente { get; set; }

        public int Fk_prodotto { get; set; }


    }
}
