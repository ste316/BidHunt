/* creazione classe offerta */
public class offerta
{
    public int id_offerta {get;set;}

    public dateTime? data { get;set;}

    public float offerta { get;set;}

    //aggiugnig fk
    [ForeignKey("")]
    public int fk_asta_id { get;set;}

    //aggiungi fk
    [ForeignKey("")]
    public int fk_utente_id { get;set;}

}