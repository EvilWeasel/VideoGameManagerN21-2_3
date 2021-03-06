// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PflegeboxAPI.DataAccess;

#nullable disable

namespace PflegeboxAPI.Migrations
{
    [DbContext(typeof(DataModelContext))]
    [Migration("20220506125943_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("PflegeboxAPI.DataAccess.Adresse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Hausnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nachname")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Ort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Plz")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Strasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adressen");
                });

            modelBuilder.Entity("PflegeboxAPI.DataAccess.PflegeboxAntrag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BoxArt")
                        .HasColumnType("int");

                    b.Property<int?>("EmpfaengerAdresseId")
                        .HasColumnType("int");

                    b.Property<bool>("IstPrivatVersichert")
                        .HasColumnType("bit");

                    b.Property<string>("Krankenkasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LieferAdresseId")
                        .HasColumnType("int");

                    b.Property<string>("VersichertenNummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EmpfaengerAdresseId");

                    b.HasIndex("LieferAdresseId");

                    b.ToTable("PflegeboxAntraege");
                });

            modelBuilder.Entity("PflegeboxAPI.DataAccess.PflegeboxAntrag", b =>
                {
                    b.HasOne("PflegeboxAPI.DataAccess.Adresse", "EmpfaengerAdresse")
                        .WithMany()
                        .HasForeignKey("EmpfaengerAdresseId");

                    b.HasOne("PflegeboxAPI.DataAccess.Adresse", "LieferAdresse")
                        .WithMany()
                        .HasForeignKey("LieferAdresseId");

                    b.Navigation("EmpfaengerAdresse");

                    b.Navigation("LieferAdresse");
                });
#pragma warning restore 612, 618
        }
    }
}
