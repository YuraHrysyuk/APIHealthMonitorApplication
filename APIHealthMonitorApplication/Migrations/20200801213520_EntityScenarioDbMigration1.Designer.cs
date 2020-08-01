﻿// <auto-generated />
using System;
using APIHealthMonitorApplication.EntityScenario.DataAccess.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace APIHealthMonitorApplication.Migrations
{
    [DbContext(typeof(EntityScenarioDbContext))]
    [Migration("20200801213520_EntityScenarioDbMigration1")]
    partial class EntityScenarioDbMigration1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("APIHealthMonitorApplication.EntityScenario.DataEntity.Endpoint", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ConnectionPath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ScenarioID")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ID");

                    b.HasIndex("ScenarioID");

                    b.ToTable("Endpoints");
                });

            modelBuilder.Entity("APIHealthMonitorApplication.EntityScenario.DataEntity.Scenario", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Comments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Scenarios");
                });

            modelBuilder.Entity("APIHealthMonitorApplication.EntityScenario.DataEntity.Endpoint", b =>
                {
                    b.HasOne("APIHealthMonitorApplication.EntityScenario.DataEntity.Scenario", "Scenario")
                        .WithMany("Endpoints")
                        .HasForeignKey("ScenarioID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
