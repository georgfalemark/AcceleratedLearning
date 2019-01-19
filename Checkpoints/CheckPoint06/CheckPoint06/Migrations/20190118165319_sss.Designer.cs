﻿// <auto-generated />
using System;
using CheckPoint06;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CheckPoint06.Migrations
{
    [DbContext(typeof(SpaceShipContext))]
    [Migration("20190118165319_sss")]
    partial class sss
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.1-servicing-10028")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CheckPoint06.Ravioli", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PackDate");

                    b.Property<int?>("SpaceShipId");

                    b.HasKey("Id");

                    b.HasIndex("SpaceShipId");

                    b.ToTable("raviolis");
                });

            modelBuilder.Entity("CheckPoint06.SpaceShip", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<int?>("ravioliId");

                    b.HasKey("Id");

                    b.HasIndex("ravioliId");

                    b.ToTable("spaceShips");
                });

            modelBuilder.Entity("CheckPoint06.Ravioli", b =>
                {
                    b.HasOne("CheckPoint06.SpaceShip")
                        .WithMany("raviolis")
                        .HasForeignKey("SpaceShipId");
                });

            modelBuilder.Entity("CheckPoint06.SpaceShip", b =>
                {
                    b.HasOne("CheckPoint06.Ravioli", "ravioli")
                        .WithMany()
                        .HasForeignKey("ravioliId");
                });
#pragma warning restore 612, 618
        }
    }
}
