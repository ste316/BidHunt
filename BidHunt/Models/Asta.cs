using BidHunt.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace BidHunt.Migrations
{
    public class Asta
    {
        public int Id { get; set; }

        public DateTime DataInizio { get; set; }

        public DateTime DataFine { get; set; }    

        public string Nome_prodotto { get; set; }

        public string Descrizione_prodotto { get; set; }

        public float Prezzo_iniziale_prod { get; set; }

        [ForeignKey("User")]
        public int? fk_utente_id { get; set; }

    }
}
