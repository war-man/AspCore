﻿// <auto-generated />
using Bai14.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Bai14.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20190623033820_v2")]
    partial class v2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Bai14.Models.HangHoa", b =>
                {
                    b.Property<int>("MaHH")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("DonGia");

                    b.Property<string>("Hinh")
                        .HasMaxLength(250);

                    b.Property<int>("MaLoai");

                    b.Property<int>("SoLuong");

                    b.Property<string>("TenHH")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaHH");

                    b.HasIndex("MaLoai");

                    b.ToTable("HangHoa");
                });

            modelBuilder.Entity("Bai14.Models.KhachHang", b =>
                {
                    b.Property<string>("MaKH")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(20);

                    b.Property<string>("DienThoai")
                        .HasMaxLength(50);

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Email")
                        .HasMaxLength(150);

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaKH");

                    b.ToTable("KhachHangs");

                    b.HasDiscriminator<string>("Discriminator").HasValue("KhachHang");
                });

            modelBuilder.Entity("Bai14.Models.Loai", b =>
                {
                    b.Property<int>("MaLoai")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Hinh")
                        .HasMaxLength(250);

                    b.Property<string>("MoTa")
                        .HasMaxLength(250);

                    b.Property<bool>("SuDung");

                    b.Property<string>("TenLoai")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("MaLoai");

                    b.ToTable("Loai");
                });

            modelBuilder.Entity("Bai14.Models.Customer", b =>
                {
                    b.HasBaseType("Bai14.Models.KhachHang");


                    b.ToTable("Customer");

                    b.HasDiscriminator().HasValue("Customer");
                });

            modelBuilder.Entity("Bai14.Models.HangHoa", b =>
                {
                    b.HasOne("Bai14.Models.Loai", "Loai")
                        .WithMany()
                        .HasForeignKey("MaLoai")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
