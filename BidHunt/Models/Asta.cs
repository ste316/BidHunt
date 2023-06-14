using BidHunt.Models;

namespace BidHunt.Migrations
{
    public class Asta
    {
        public int Id { get; set; }

        public DateTime DataInizio { get; set; }

        public DateTime DataFine { get; set; }    

        public int Fk_prodotto { get; set; }

        public ICollection<Offerta> offerte{ get; set; }

    }
}
