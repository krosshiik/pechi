using Microsoft.EntityFrameworkCore;
using Pechi.DataBase;

public class Context : DbContext
{
    public DbSet<Agregati> Технологические_агрегаты { get; set; }
    public DbSet<Litsa> Ответственные_лица { get; set; }
    public DbSet<Prostoi> Простои { get; set; }
    public DbSet<Tipi> Типы_простоев { get; set; }
    public DbSet<RegistrationData> Регистрация { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-T8VQDF1;Database=Yan_Pechi;Trusted_Connection=True;TrustServerCertificate=true;Encrypt=False;");
    }
/*    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<RegistrationData>().HasKey(r => r.Login);
    }*/
}
