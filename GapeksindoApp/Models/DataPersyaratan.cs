
namespace GapeksindoApp.Models;

public class  DataPersyaratan{
    public int Id { get; set; }
    public Persyaratan Persyaratan {get;set;}
    public string? FileNama { get; set; }   
    public bool Status { get; set; }
}