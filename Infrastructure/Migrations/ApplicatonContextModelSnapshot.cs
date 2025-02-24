﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicatonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entity.Demande", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Commentaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateOnly>("DateDebut")
                        .HasColumnType("date");

                    b.Property<DateOnly>("DateFin")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("EstActif")
                        .HasColumnType("bit");

                    b.Property<int>("Statut")
                        .HasColumnType("int");

                    b.Property<int>("TypeDemande")
                        .HasColumnType("int");

                    b.Property<Guid>("UtilisateurCreation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UtilisateurModification")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeId");

                    b.ToTable("Demande");
                });

            modelBuilder.Entity("Core.Entity.Employe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<bool>("EstActif")
                        .HasColumnType("bit");

                    b.Property<string>("Matricule")
                        .IsRequired()
                        .HasColumnType("Varchar(15)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("Varchar(15)");

                    b.Property<string>("TelephoneProfessionnel")
                        .IsRequired()
                        .HasColumnType("Varchar(15)");

                    b.Property<Guid>("UtilisateurCreation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UtilisateurModification")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Employes");
                });

            modelBuilder.Entity("Core.Entity.EmployeFonction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("EmployeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("EstActif")
                        .HasColumnType("bit");

                    b.Property<Guid>("FonctionId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ServiceId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UtilisateurCreation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UtilisateurModification")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("EmployeId");

                    b.HasIndex("FonctionId");

                    b.HasIndex("ServiceId");

                    b.ToTable("EmployeFonction");
                });

            modelBuilder.Entity("Core.Entity.Fonction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EstActif")
                        .HasColumnType("bit");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<Guid>("UtilisateurCreation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UtilisateurModification")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Fonction");
                });

            modelBuilder.Entity("Core.Entity.Service", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("Varchar(20)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EstActif")
                        .HasColumnType("bit");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<Guid>("UtilisateurCreation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UtilisateurModification")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("Core.Entity.Validations", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Commentaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateValidation")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("DemandeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("EmployeValidateurId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("EstActif")
                        .HasColumnType("bit");

                    b.Property<int>("Statut")
                        .HasColumnType("int");

                    b.Property<Guid>("UtilisateurCreation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UtilisateurModification")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("DemandeId");

                    b.HasIndex("EmployeValidateurId");

                    b.ToTable("Validation");
                });

            modelBuilder.Entity("Core.Entity.Demande", b =>
                {
                    b.HasOne("Core.Entity.Employe", "Employe")
                        .WithMany()
                        .HasForeignKey("EmployeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");
                });

            modelBuilder.Entity("Core.Entity.EmployeFonction", b =>
                {
                    b.HasOne("Core.Entity.Employe", "Employe")
                        .WithMany()
                        .HasForeignKey("EmployeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entity.Fonction", "Fonction")
                        .WithMany()
                        .HasForeignKey("FonctionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entity.Service", "Service")
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employe");

                    b.Navigation("Fonction");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("Core.Entity.Validations", b =>
                {
                    b.HasOne("Core.Entity.Demande", "Demande")
                        .WithMany()
                        .HasForeignKey("DemandeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entity.Employe", "EmployeValidateur")
                        .WithMany()
                        .HasForeignKey("EmployeValidateurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Demande");

                    b.Navigation("EmployeValidateur");
                });
#pragma warning restore 612, 618
        }
    }
}
