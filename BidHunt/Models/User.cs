using System.ComponentModel.DataAnnotations.Schema;

namespace BidHunt.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public DateTime DataNascita { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // add fk https://www.entityframeworktutorial.net/code-first/foreignkey-dataannotations-attribute-in-code-first.aspx
        [ForeignKey("MetodoPagamento")]
        public int MetodoPagamentoRefId { get; set; }
        public MetodoPagamento MetodoPagamento { get; set; }

    }
}
