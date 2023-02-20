namespace GapeksindoApp.Models;

public class RegistrasiPerusahaan:Perusahaan{
    public string Password {get;set;}
    public string ConfirmPassword { get; set; }
}