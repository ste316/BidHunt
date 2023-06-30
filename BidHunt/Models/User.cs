using BidHunt.Migrations;
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

        public string PayPal_mail { get; set; }
        

    }
}
