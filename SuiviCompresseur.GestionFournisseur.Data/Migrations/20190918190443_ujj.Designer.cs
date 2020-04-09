﻿// <auto-generated />
using System;
using SuiviCompresseur.GestionFournisseur.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SuiviCompresseur.GestionFournisseur.Data.Migrations
{
    [DbContext(typeof(FournisseurDbContext))]
    [Migration("20190918190443_ujj")]
    partial class ujj
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuiviCompresseur.GestionFournisseur.Domain.Models.Fournisseur", b =>
                {
                    b.Property<Guid>("FournisseurID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Adresse");

                    b.Property<string>("Email");

                    b.Property<string>("Nom")
                        .IsRequired();

                    b.HasKey("FournisseurID");

                    b.ToTable("Fournisseurs");
                });
#pragma warning restore 612, 618
        }
    }
}