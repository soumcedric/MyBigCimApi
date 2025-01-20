﻿// <auto-generated />
using System;
using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infrastructure.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20241217234909_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entity.Employe", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<bool>("EstActif")
                        .HasColumnType("bit");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("Varchar(50)");

                    b.Property<string>("Telephone")
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
#pragma warning restore 612, 618
        }
    }
}
