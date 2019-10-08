﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using OnePieceApp.Data;

namespace OnePieceApp.Data.Migrations
{
    [DbContext(typeof(OnePieceContext))]
    partial class OnePieceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.11-servicing-32099")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("OnePieceApp.Domain.Character", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ClanId");

                    b.Property<string>("Description");

                    b.Property<int>("DevilFruitId");

                    b.Property<string>("Name");

                    b.Property<string>("Sex");

                    b.HasKey("Id");

                    b.HasIndex("ClanId");

                    b.HasIndex("DevilFruitId");

                    b.ToTable("Characters");
                });

            modelBuilder.Entity("OnePieceApp.Domain.Clan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("OnePieceApp.Domain.DevilFruit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<string>("Power");

                    b.HasKey("Id");

                    b.ToTable("DevilFruits");
                });

            modelBuilder.Entity("OnePieceApp.Domain.Character", b =>
                {
                    b.HasOne("OnePieceApp.Domain.Clan", "Clan")
                        .WithMany("Characters")
                        .HasForeignKey("ClanId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("OnePieceApp.Domain.DevilFruit", "DevilFruit")
                        .WithMany()
                        .HasForeignKey("DevilFruitId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
