﻿// <auto-generated />
using System;
using SuiviCompresseur.Notification.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace SuiviCompresseur.Notification.Data.Migrations
{
    [DbContext(typeof(Notification_context))]
    [Migration("20190913163542_Test1")]
    partial class Test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SuiviCompresseur.Notification.Domain.Models.EmailFrom", b =>
                {
                    b.Property<Guid>("IdMail")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content");

                    b.Property<string>("ExceptionMessage");

                    b.Property<string>("FromAddresses");

                    b.Property<string>("FromName");

                    b.Property<string>("MessageType");

                    b.Property<DateTime>("SendDate");

                    b.Property<string>("Subject");

                    b.HasKey("IdMail");

                    b.ToTable("EmailFroms");
                });

            modelBuilder.Entity("SuiviCompresseur.Notification.Domain.Models.EmailTo", b =>
                {
                    b.Property<Guid>("IdTo")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("IdMail");

                    b.Property<string>("ReceiveType");

                    b.Property<bool>("Seen");

                    b.Property<string>("ToAddresses");

                    b.Property<string>("ToName");

                    b.HasKey("IdTo");

                    b.HasIndex("IdMail");

                    b.ToTable("EmailTos");
                });

            modelBuilder.Entity("SuiviCompresseur.Notification.Domain.Models.EmailTo", b =>
                {
                    b.HasOne("SuiviCompresseur.Notification.Domain.Models.EmailFrom")
                        .WithMany("EmailTos")
                        .HasForeignKey("IdMail")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}