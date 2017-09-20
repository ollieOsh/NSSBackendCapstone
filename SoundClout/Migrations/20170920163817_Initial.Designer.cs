using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using SoundClout.Data;

namespace SoundClout.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20170920163817_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SoundClout.Models.MainName", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("NumerologyInt");

                    b.Property<int>("OrderInt");

                    b.Property<int>("PrefixInt");

                    b.Property<int>("SyllableCount");

                    b.Property<int>("Weekday");

                    b.Property<string>("Word")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("MainName");
                });
        }
    }
}
