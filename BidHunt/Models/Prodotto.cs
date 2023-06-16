using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


//aggiungi a apidbcontext
namespace BidHunt.Models
{
    public class Prodotto
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Categories { get; set; }

        //definire bene tutti i campi

        [ForeignKey("User")]
        public int? fk_utente_id { get; set; }
    }
}
