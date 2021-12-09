﻿// <auto-generated />
using System;
using DataAccess.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(OnlineSinavSistemiContext))]
    [Migration("20211101041610_af")]
    partial class af
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Concrete.Brans", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<int?>("UstBransId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UstBransId");

                    b.ToTable("Brans");
                });

            modelBuilder.Entity("Entities.Concrete.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Baslik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DokumanUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Icerik")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KursId")
                        .HasColumnType("int");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<string>("VideoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KursId");

                    b.ToTable("Ders");
                });

            modelBuilder.Entity("Entities.Concrete.Kullanici", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FotoUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sifre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<string>("Soyad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("Tc")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Kullanici");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Kullanici");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciCevap", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cevap")
                        .IsRequired()
                        .HasColumnType("nvarchar(1)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciSinavId")
                        .HasColumnType("int");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<int>("SoruId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciSinavId");

                    b.HasIndex("SoruId");

                    b.ToTable("KullaniciCevap");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciDetay", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<string>("Mezuniyet")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<string>("Telefon")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("KullaniciDetay");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciKurs", b =>
                {
                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("KursId")
                        .HasColumnType("int");

                    b.Property<string>("Durum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("KullaniciId", "KursId");

                    b.HasIndex("KursId");

                    b.ToTable("KullaniciKurs");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciRol", b =>
                {
                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("RolId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("KullaniciId", "RolId");

                    b.HasIndex("RolId");

                    b.ToTable("KullaniciRol");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciSinav", b =>
                {
                    b.Property<int>("SinavId")
                        .HasColumnType("int");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<bool>("SinavBittiMi")
                        .HasColumnType("bit");

                    b.HasKey("SinavId", "KullaniciId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("KullaniciSinav");
                });

            modelBuilder.Entity("Entities.Concrete.Kurs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BaslamaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("BitisTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("BittiMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("HaftalikCalisma")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<int>("SinavId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SinavId")
                        .IsUnique();

                    b.ToTable("Kurs");
                });

            modelBuilder.Entity("Entities.Concrete.KursDers", b =>
                {
                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("KullaniciId", "DersId");

                    b.HasIndex("DersId");

                    b.ToTable("KursDers");
                });

            modelBuilder.Entity("Entities.Concrete.KursMerkezii", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adres")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Il")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ilce")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KursMerkeziId")
                        .HasColumnType("int");

                    b.Property<string>("LocationUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<short>("TelefonNumarasi")
                        .HasColumnType("smallint");

                    b.HasKey("Id");

                    b.ToTable("KursMerkezii");
                });

            modelBuilder.Entity("Entities.Concrete.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Rol");
                });

            modelBuilder.Entity("Entities.Concrete.Sikayet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Sikayet");
                });

            modelBuilder.Entity("Entities.Concrete.Sinav", b =>
                {
                    b.Property<int>("OgretmenId")
                        .HasColumnType("int");

                    b.Property<int>("KaydedenKullaniciId")
                        .HasColumnType("int");

                    b.Property<int>("BransId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<byte>("Kontenjan")
                        .HasColumnType("tinyint");

                    b.Property<int>("KursMerkeziId")
                        .HasColumnType("int");

                    b.Property<bool>("OturumBittiMi")
                        .HasColumnType("bit");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<DateTime>("SinavSaati")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("SinavTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Sinif")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte>("SoruSayisi")
                        .HasColumnType("tinyint");

                    b.Property<int>("Suresi")
                        .HasColumnType("int");

                    b.HasKey("OgretmenId", "KaydedenKullaniciId");

                    b.HasIndex("BransId");

                    b.HasIndex("KaydedenKullaniciId");

                    b.HasIndex("KursMerkeziId");

                    b.ToTable("Sinav");
                });

            modelBuilder.Entity("Entities.Concrete.SinavSoru", b =>
                {
                    b.Property<int>("SinavId")
                        .HasColumnType("int");

                    b.Property<int>("SoruId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("SinavId", "SoruId");

                    b.HasIndex("SoruId");

                    b.ToTable("SinavSoru");
                });

            modelBuilder.Entity("Entities.Concrete.Soru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BransId")
                        .HasColumnType("int");

                    b.Property<string>("Cevap")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<bool>("OnaylandiMi")
                        .HasColumnType("bit");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.Property<string>("SoruMetni")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZorlukSeviyesi")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Soru");
                });

            modelBuilder.Entity("Entities.Concrete.Yorum", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("KullaniciId")
                        .HasColumnType("int");

                    b.Property<bool>("SilindiMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("DersId");

                    b.HasIndex("KullaniciId");

                    b.ToTable("Yorum");
                });

            modelBuilder.Entity("Entities.Concrete.Ogretmen", b =>
                {
                    b.HasBaseType("Entities.Concrete.Kullanici");

                    b.HasDiscriminator().HasValue("Ogretmen");
                });

            modelBuilder.Entity("Entities.Concrete.Yonetici", b =>
                {
                    b.HasBaseType("Entities.Concrete.Kullanici");

                    b.HasDiscriminator().HasValue("Yonetici");
                });

            modelBuilder.Entity("Entities.Concrete.Brans", b =>
                {
                    b.HasOne("Entities.Concrete.Brans", "UstBransi")
                        .WithMany()
                        .HasForeignKey("UstBransId");

                    b.Navigation("UstBransi");
                });

            modelBuilder.Entity("Entities.Concrete.Ders", b =>
                {
                    b.HasOne("Entities.Concrete.Kurs", "Kurs")
                        .WithMany("Ders")
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kurs");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciCevap", b =>
                {
                    b.HasOne("Entities.Concrete.KullaniciSinav", "KullaniciSinav")
                        .WithMany("KullaniciSinavCevaplari")
                        .HasForeignKey("KullaniciSinavId")
                        .HasPrincipalKey("Id")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Soru", "Soru")
                        .WithMany()
                        .HasForeignKey("SoruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KullaniciSinav");

                    b.Navigation("Soru");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciDetay", b =>
                {
                    b.HasOne("Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciKurs", b =>
                {
                    b.HasOne("Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany("KullaniciKurs")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Kurs", "Kurs")
                        .WithMany("KullaniciKurs")
                        .HasForeignKey("KursId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Kurs");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciRol", b =>
                {
                    b.HasOne("Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany("KullaniciRoller")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Rol", "Rol")
                        .WithMany("KullaniciRoller")
                        .HasForeignKey("RolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Rol");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciSinav", b =>
                {
                    b.HasOne("Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany("KullaniciSinavlari")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Sinav", "Sinav")
                        .WithMany("KullaniciSinav")
                        .HasForeignKey("SinavId")
                        .HasPrincipalKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanici");

                    b.Navigation("Sinav");
                });

            modelBuilder.Entity("Entities.Concrete.Kurs", b =>
                {
                    b.HasOne("Entities.Concrete.Sinav", "Sinav")
                        .WithOne("Kurs")
                        .HasForeignKey("Entities.Concrete.Kurs", "SinavId")
                        .HasPrincipalKey("Entities.Concrete.Sinav", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinav");
                });

            modelBuilder.Entity("Entities.Concrete.KursDers", b =>
                {
                    b.HasOne("Entities.Concrete.Ders", "Ders")
                        .WithMany("KullanicininDersleri")
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany("KullanicininDersleri")
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Entities.Concrete.Sikayet", b =>
                {
                    b.HasOne("Entities.Concrete.Kullanici", "Kullanicisi")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kullanicisi");
                });

            modelBuilder.Entity("Entities.Concrete.Sinav", b =>
                {
                    b.HasOne("Entities.Concrete.Brans", "Brans")
                        .WithMany()
                        .HasForeignKey("BransId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Yonetici", "KaydedenKullanici")
                        .WithMany("KaydedilenSinavlar")
                        .HasForeignKey("KaydedenKullaniciId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.KursMerkezii", "KursMerkezi")
                        .WithMany()
                        .HasForeignKey("KursMerkeziId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Ogretmen", "Ogretmen")
                        .WithMany("OgretmeniOlunanSinavlar")
                        .HasForeignKey("OgretmenId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Brans");

                    b.Navigation("KaydedenKullanici");

                    b.Navigation("KursMerkezi");

                    b.Navigation("Ogretmen");
                });

            modelBuilder.Entity("Entities.Concrete.SinavSoru", b =>
                {
                    b.HasOne("Entities.Concrete.Sinav", "Sinav")
                        .WithMany("SinavSorulari")
                        .HasForeignKey("SinavId")
                        .HasPrincipalKey("Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Soru", "Soru")
                        .WithMany("SinavSorulari")
                        .HasForeignKey("SoruId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sinav");

                    b.Navigation("Soru");
                });

            modelBuilder.Entity("Entities.Concrete.Yorum", b =>
                {
                    b.HasOne("Entities.Concrete.Ders", "Ders")
                        .WithMany()
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entities.Concrete.Kullanici", "Kullanici")
                        .WithMany()
                        .HasForeignKey("KullaniciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Kullanici");
                });

            modelBuilder.Entity("Entities.Concrete.Ders", b =>
                {
                    b.Navigation("KullanicininDersleri");
                });

            modelBuilder.Entity("Entities.Concrete.Kullanici", b =>
                {
                    b.Navigation("KullaniciKurs");

                    b.Navigation("KullanicininDersleri");

                    b.Navigation("KullaniciRoller");

                    b.Navigation("KullaniciSinavlari");
                });

            modelBuilder.Entity("Entities.Concrete.KullaniciSinav", b =>
                {
                    b.Navigation("KullaniciSinavCevaplari");
                });

            modelBuilder.Entity("Entities.Concrete.Kurs", b =>
                {
                    b.Navigation("Ders");

                    b.Navigation("KullaniciKurs");
                });

            modelBuilder.Entity("Entities.Concrete.Rol", b =>
                {
                    b.Navigation("KullaniciRoller");
                });

            modelBuilder.Entity("Entities.Concrete.Sinav", b =>
                {
                    b.Navigation("KullaniciSinav");

                    b.Navigation("Kurs");

                    b.Navigation("SinavSorulari");
                });

            modelBuilder.Entity("Entities.Concrete.Soru", b =>
                {
                    b.Navigation("SinavSorulari");
                });

            modelBuilder.Entity("Entities.Concrete.Ogretmen", b =>
                {
                    b.Navigation("OgretmeniOlunanSinavlar");
                });

            modelBuilder.Entity("Entities.Concrete.Yonetici", b =>
                {
                    b.Navigation("KaydedilenSinavlar");
                });
#pragma warning restore 612, 618
        }
    }
}
