/* creazione classe offerta */
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Offerta
{
    [Key]
    public int id_offerta {get;set;}

    public DateTime? data { get;set;}

    public float offerta { get;set;}

    //aggiungi fk
    [ForeignKey("Asta")]
    public int fk_asta_id { get;set;}

    //aggiungi fk
    [ForeignKey("User")]
    public int fk_utente_id { get;set;}

}