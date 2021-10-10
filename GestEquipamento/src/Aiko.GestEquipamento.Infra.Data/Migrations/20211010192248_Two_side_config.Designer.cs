﻿// <auto-generated />
using System;
using Aiko.GestEquipamento.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Aiko.GestEquipamento.Infra.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20211010192248_Two_side_config")]
    partial class Two_side_config
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("operation")
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.Equipment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<Guid>("EquipmentModelId")
                        .HasColumnType("uuid")
                        .HasColumnName("equipment_model_id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.HasIndex("EquipmentModelId");

                    b.ToTable("equipment");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.EquipmentModel", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("equipment_model");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.EquipmentModelStateHourlyEarnings", b =>
                {
                    b.Property<Guid>("EquipmentModelId")
                        .HasColumnType("uuid")
                        .HasColumnName("equipment_model_id");

                    b.Property<Guid>("EquipmentStateId")
                        .HasColumnType("uuid")
                        .HasColumnName("equipment_state_id");

                    b.Property<float>("Value")
                        .HasColumnType("real")
                        .HasColumnName("value");

                    b.HasIndex("EquipmentModelId");

                    b.HasIndex("EquipmentStateId");

                    b.ToTable("equipment_model_state_hourly_earnings");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.EquipmentPositionHistory", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date");

                    b.Property<Guid>("EquipmentId")
                        .HasColumnType("uuid")
                        .HasColumnName("equipment_id");

                    b.Property<float>("Lat")
                        .HasColumnType("real")
                        .HasColumnName("lat");

                    b.Property<float>("Lon")
                        .HasColumnType("real")
                        .HasColumnName("lon");

                    b.HasIndex("EquipmentId");

                    b.ToTable("equipment_position_history");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.EquipmentState", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid")
                        .HasColumnName("id");

                    b.Property<string>("Color")
                        .HasColumnType("text")
                        .HasColumnName("color");

                    b.Property<string>("Name")
                        .HasColumnType("text")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("equipment_state");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.EquipmentStateHistory", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("date");

                    b.Property<Guid>("EquipmentId")
                        .HasColumnType("uuid")
                        .HasColumnName("equipment_id");

                    b.Property<Guid>("EquipmentStateId")
                        .HasColumnType("uuid")
                        .HasColumnName("equipment_state_id");

                    b.HasIndex("EquipmentId");

                    b.HasIndex("EquipmentStateId");

                    b.ToTable("equipment_state_history");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.Equipment", b =>
                {
                    b.HasOne("Aiko.GestEquipamento.Domain.Entities.EquipmentModel", "EquipmentModel")
                        .WithMany("Equipments")
                        .HasForeignKey("EquipmentModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EquipmentModel");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.EquipmentModelStateHourlyEarnings", b =>
                {
                    b.HasOne("Aiko.GestEquipamento.Domain.Entities.EquipmentModel", "EquipmentModel")
                        .WithMany()
                        .HasForeignKey("EquipmentModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aiko.GestEquipamento.Domain.Entities.EquipmentState", "EquipmentState")
                        .WithMany()
                        .HasForeignKey("EquipmentStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("EquipmentModel");

                    b.Navigation("EquipmentState");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.EquipmentPositionHistory", b =>
                {
                    b.HasOne("Aiko.GestEquipamento.Domain.Entities.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.EquipmentStateHistory", b =>
                {
                    b.HasOne("Aiko.GestEquipamento.Domain.Entities.Equipment", "Equipment")
                        .WithMany()
                        .HasForeignKey("EquipmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Aiko.GestEquipamento.Domain.Entities.EquipmentState", "EquipmentState")
                        .WithMany()
                        .HasForeignKey("EquipmentStateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Equipment");

                    b.Navigation("EquipmentState");
                });

            modelBuilder.Entity("Aiko.GestEquipamento.Domain.Entities.EquipmentModel", b =>
                {
                    b.Navigation("Equipments");
                });
#pragma warning restore 612, 618
        }
    }
}
