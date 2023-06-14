using System.ComponentModel.DataAnnotations.Schema;

namespace BidHunt.Migrations
{
    public class Asta
    {
        public int Id { get; set; }

        [ForeignKey("offerta")]
        public int fk_offerta { get; set; }

        public DateTime TempoRimanente { get; set; }

        [ForeignKey("prodotto")]
        public int Fk_prodotto { get; set; }


    }
}
