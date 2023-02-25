using GapeksindoApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GapeksindoApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Persyaratan> Persyaratans { get; set; }
        public DbSet<Kualifikasi> Kualifikasis{ get; set; }
        public DbSet<Permohonan> Permohonans { get; set; }
        public DbSet<Perusahaan> Perusahaans{ get; set; }
        public DbSet<Kabupaten> Kabupatens{ get; set; }
    }
}