
namespace GapeksindoApp.Models;

public class  Persyaratan{

    public int Id { get; set; }
    public string Nama { get; set; }   
    public bool IsUpload { get; set; }=true;
    public string Keterangan { get; set; }
}