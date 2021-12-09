using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class OnlineSinavSistemiContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=SinavSistemi; Trusted_Connection=true;");
            //optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=SinavSistemi; integrated security=true;");
            //optionsBuilder.UseSqlServer(@"Data Source =LAB08-OGRETMEN; Initial Catalog = OSS; Trusted_Connection = True;");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Brans> Brans { get; set; }
        public DbSet<Ders> Ders { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<KullaniciCevap> KullaniciCevap { get; set; }
        public DbSet<KullaniciDetay> KullaniciDetay { get; set; }
        public DbSet<KullaniciKurs> KullaniciKurs { get; set; }
        public DbSet<KullaniciRol> KullaniciRol { get; set; }
        public DbSet<KullaniciSinav> KullaniciSinav { get; set; }
        public DbSet<Kurs> Kurs { get; set; }
        public DbSet<KursDers> KursDers { get; set; }
        public DbSet<KursMerkezii> KursMerkezii { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Sikayet> Sikayet { get; set; }
        public DbSet<Sinav> Sinav { get; set; }
        public DbSet<SinavSoru> SinavSoru { get; set; }
        public DbSet<Soru> Soru { get; set; }
        public DbSet<Yorum> Yorum { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KullaniciRol>().HasKey(kr => new { kr.KullaniciId, kr.RolId });
            modelBuilder.Entity<KullaniciRol>().HasOne(kr => kr.Kullanici).WithMany(k => k.KullaniciRoller).HasForeignKey(kr => kr.KullaniciId);
            modelBuilder.Entity<KullaniciRol>().HasOne(kr => kr.Rol).WithMany(r => r.KullaniciRoller).HasForeignKey(kr => kr.RolId);

            modelBuilder.Entity<SinavSoru>().HasKey(ss => new { ss.SinavId, ss.SoruId });
            modelBuilder.Entity<SinavSoru>().HasOne(ss => ss.Sinav).WithMany(i => i.SinavSorulari).HasForeignKey(ss => ss.SinavId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<SinavSoru>().HasOne(ss => ss.Soru).WithMany(o => o.SinavSorulari).HasForeignKey(ss => ss.SoruId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<KullaniciSinav>().HasKey(ks => new { ks.SinavId, ks.KullaniciId });
            modelBuilder.Entity<KullaniciSinav>().HasOne(ks => ks.Sinav).WithMany(i => i.KullaniciSinav).HasForeignKey(ss => ss.SinavId).HasPrincipalKey(x => x.Id);
            modelBuilder.Entity<KullaniciSinav>().HasOne(ks => ks.Kullanici).WithMany(o => o.KullaniciSinavlari).HasForeignKey(ss => ss.KullaniciId).HasPrincipalKey(x => x.Id);

            modelBuilder.Entity<KullaniciKurs>().HasKey(kk => new { kk.KullaniciId, kk.KursId });
            modelBuilder.Entity<KullaniciKurs>().HasOne(kk => kk.Kullanici).WithMany(i => i.KullaniciKurs).HasForeignKey(kk => kk.KullaniciId);
            modelBuilder.Entity<KullaniciKurs>().HasOne(kk => kk.Kurs).WithMany(u => u.KullaniciKurs).HasForeignKey(kk => kk.KursId);

            modelBuilder.Entity<KursDers>().HasKey(kd => new { kd.KullaniciId, kd.DersId });
            modelBuilder.Entity<KursDers>().HasOne(kd => kd.Kullanici).WithMany(i => i.KullanicininDersleri).HasForeignKey(kd => kd.KullaniciId);
            modelBuilder.Entity<KursDers>().HasOne(kd => kd.Ders).WithMany(u => u.KullanicininDersleri).HasForeignKey(kd => kd.DersId);

            modelBuilder.Entity<Sinav>().HasKey(s => new { s.OgretmenId, s.KaydedenKullaniciId });
            modelBuilder.Entity<Sinav>().HasOne<Ogretmen>(e => e.Ogretmen).WithMany(e => e.OgretmeniOlunanSinavlar).HasForeignKey(e => e.OgretmenId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Sinav>().HasOne<Yonetici>(e => e.KaydedenKullanici).WithMany(e => e.KaydedilenSinavlar).HasForeignKey(e => e.KaydedenKullaniciId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<KullaniciCevap>().HasOne<KullaniciSinav>(e => e.KullaniciSinav).WithMany(e => e.KullaniciSinavCevaplari).HasForeignKey(e => e.KullaniciSinavId).HasPrincipalKey(x => x.Id).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Kurs>().HasOne(a => a.Sinav).WithOne(b => b.Kurs).HasPrincipalKey<Sinav>(x => x.Id).HasForeignKey<Kurs>(b => b.SinavId);
            base.OnModelCreating(modelBuilder);
        }
    }
}

