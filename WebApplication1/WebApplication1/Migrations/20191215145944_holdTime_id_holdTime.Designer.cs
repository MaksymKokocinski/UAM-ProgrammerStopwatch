﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt.Data;

namespace Projekt.Migrations
{
    [DbContext(typeof(baza_danychContext))]
    [Migration("20191215145944_holdTime_id_holdTime")]
    partial class holdTime_id_holdTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projekt.Models.holdTime", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("czas_end");

                    b.Property<int>("czas_start");

                    b.HasKey("id");

                    b.ToTable("holdTime");
                });

            modelBuilder.Entity("Projekt.Models.Tasks", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("diffrence");

                    b.Property<int>("id_holdTime");

                    b.Property<string>("name");

                    b.Property<bool>("stan");

                    b.Property<int>("time_admin");

                    b.Property<int>("time_user");

                    b.HasKey("id");

                    b.ToTable("tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
