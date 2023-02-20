namespace GapeksindoApp.Models;

public class Perusahaan{
    public int Id { get; set; }
    public string Bentuk {get;set;}
    public string NamaPerusahaan { get; set; }
    public string FullName => $"{Bentuk}.  {NamaPerusahaan}";
    public string? Pimpinan { get; set; }
    public string? NPWP { get; set; }
    public string Email { get; set; }
    public string? Telepon{ get; set; }
    public string? Alamat{ get; set; }
    public bool Status { get; set; }=true;
    public string? UserId{ get; set; }
}