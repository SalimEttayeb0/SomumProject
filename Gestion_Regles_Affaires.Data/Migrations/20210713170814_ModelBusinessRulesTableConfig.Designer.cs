﻿// <auto-generated />
using System;
using Gestion_Regles_Affaires.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gestion_Regles_Affaires.Data.Migrations
{
    [DbContext(typeof(ReglesAffairesContext))]
    [Migration("20210713170814_ModelBusinessRulesTableConfig")]
    partial class ModelBusinessRulesTableConfig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.7")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.BusinessRules", b =>
                {
                    b.Property<int>("BusinessRulesId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("HasParameter")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRequired")
                        .HasColumnType("bit");

                    b.Property<string>("ParameterType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ParameterValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BusinessRulesId");

                    b.ToTable("BusinessRules");
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.ModelBusinessRules", b =>
                {
                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("BusinessRulesId")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelId", "BusinessRulesId");

                    b.HasIndex("BusinessRulesId");

                    b.ToTable("ModelBusinessRules");
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.Modele", b =>
                {
                    b.Property<int>("ModelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelId");

                    b.ToTable("Modeles");
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.ModelBusinessRules", b =>
                {
                    b.HasOne("Gestion_Regles_Affaires.Data.Models.BusinessRules", "BusinessRules")
                        .WithMany("ModelBusinessRules")
                        .HasForeignKey("BusinessRulesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Gestion_Regles_Affaires.Data.Models.Modele", "Model")
                        .WithMany("ModelBusinessRules")
                        .HasForeignKey("ModelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessRules");

                    b.Navigation("Model");
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.BusinessRules", b =>
                {
                    b.Navigation("ModelBusinessRules");
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.Modele", b =>
                {
                    b.Navigation("ModelBusinessRules");
                });
#pragma warning restore 612, 618
        }
    }
}