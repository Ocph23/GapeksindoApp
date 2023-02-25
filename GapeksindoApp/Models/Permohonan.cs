namespace GapeksindoApp.Models;

public class Permohonan{
    public int Id { get; set; }
    public string? Nomor { get; set; }
    public string? Keterangan { get; set; }

    public StatusPermohonan Status { get; set; }
    public DateTime? Tanggal { get; set; } = DateTime.Now;
    public DateTime? TanggalDitetapkan { get; set; } 

    public ICollection<Kualifikasi> DataKualifikasi{get;set;} = new List<Kualifikasi>();
    public ICollection<DataPersyaratan> DataPersyaratan{get;set;} = new List<DataPersyaratan>();
    public Perusahaan Perusahaan{get;set;}

    public bool ValidPersyaratan=> DataPersyaratan.Where(x=>!x.Validate).Count()>0?false:true;


}