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
    [Migration("20210714204546_ParameterTypeParameterValueMigration")]
    partial class ParameterTypeParameterValueMigration
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

                    b.Property<int>("ParameterTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BusinessRulesId");

                    b.HasIndex("ParameterTypeId");

                    b.ToTable("BusinessRules");

                    b.HasData(
                        new
                        {
                            BusinessRulesId = 1,
                            HasParameter = false,
                            IsRequired = true,
                            ParameterTypeId = 4,
                            Title = "Nombre de personnes"
                        },
                        new
                        {
                            BusinessRulesId = 2,
                            HasParameter = false,
                            IsRequired = true,
                            ParameterTypeId = 3,
                            Title = "Date de début du quart de travail proposée"
                        },
                        new
                        {
                            BusinessRulesId = 3,
                            HasParameter = false,
                            IsRequired = true,
                            ParameterTypeId = 3,
                            Title = "Date de fin du quart de travail proposée"
                        },
                        new
                        {
                            BusinessRulesId = 4,
                            HasParameter = false,
                            IsRequired = true,
                            ParameterTypeId = 3,
                            Title = "Nombre d'heure au lieu de l'heure de fin"
                        },
                        new
                        {
                            BusinessRulesId = 5,
                            HasParameter = false,
                            IsRequired = true,
                            ParameterTypeId = 4,
                            Title = "Nombre d'heures de pause"
                        },
                        new
                        {
                            BusinessRulesId = 6,
                            HasParameter = true,
                            IsRequired = true,
                            ParameterTypeId = 1,
                            Title = "Classification de l'employé"
                        },
                        new
                        {
                            BusinessRulesId = 7,
                            HasParameter = true,
                            IsRequired = false,
                            ParameterTypeId = 2,
                            Title = "Modèle horaire d'appel"
                        },
                        new
                        {
                            BusinessRulesId = 8,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 3,
                            Title = "Minimum sur le total heure pour les horaires normales"
                        },
                        new
                        {
                            BusinessRulesId = 9,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 3,
                            Title = "Heure total maximum de travail"
                        },
                        new
                        {
                            BusinessRulesId = 10,
                            HasParameter = true,
                            IsRequired = false,
                            ParameterTypeId = 2,
                            Title = "Priorisé un groupe de contacts"
                        },
                        new
                        {
                            BusinessRulesId = 11,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 1,
                            Title = "Ne pas recontacter les refusés pour le même jour"
                        },
                        new
                        {
                            BusinessRulesId = 12,
                            HasParameter = false,
                            IsRequired = true,
                            ParameterTypeId = 4,
                            Title = "Appeler en ordre de temps supplémentaire exécuté"
                        },
                        new
                        {
                            BusinessRulesId = 13,
                            HasParameter = false,
                            IsRequired = true,
                            ParameterTypeId = 4,
                            Title = "Ancienneté"
                        },
                        new
                        {
                            BusinessRulesId = 14,
                            HasParameter = false,
                            IsRequired = true,
                            ParameterTypeId = 4,
                            Title = "Employés Temps plein"
                        },
                        new
                        {
                            BusinessRulesId = 15,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 4,
                            Title = "Temps supplémentaire maximum"
                        },
                        new
                        {
                            BusinessRulesId = 16,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 4,
                            Title = "Maximum de temps travaillé"
                        },
                        new
                        {
                            BusinessRulesId = 17,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 4,
                            Title = "Temps avant le poste"
                        },
                        new
                        {
                            BusinessRulesId = 18,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 4,
                            Title = "Temps après le poste"
                        },
                        new
                        {
                            BusinessRulesId = 19,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 1,
                            Title = "Employé en usine en premier"
                        },
                        new
                        {
                            BusinessRulesId = 20,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 1,
                            Title = "Appel seulement sur les heures de travail"
                        },
                        new
                        {
                            BusinessRulesId = 21,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 5,
                            Title = "Appel différent sur les heures de travail"
                        },
                        new
                        {
                            BusinessRulesId = 22,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 4,
                            Title = "Tentative des non joints"
                        },
                        new
                        {
                            BusinessRulesId = 23,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 4,
                            Title = "Tentative à tous les contacts"
                        },
                        new
                        {
                            BusinessRulesId = 24,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 1,
                            Title = "Division de l'appel"
                        },
                        new
                        {
                            BusinessRulesId = 25,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 1,
                            Title = "Poursuivre avec la même liste"
                        },
                        new
                        {
                            BusinessRulesId = 26,
                            HasParameter = false,
                            IsRequired = false,
                            ParameterTypeId = 4,
                            Title = "Délais entre les appels"
                        },
                        new
                        {
                            BusinessRulesId = 27,
                            HasParameter = false,
                            IsRequired = true,
                            ParameterTypeId = 4,
                            Title = "Priorité de la diffusion"
                        });
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.BusinessRulesParameterValue", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("BusinessRulesId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("BusinessRulesId");

                    b.ToTable("BusinessRulesParameterValue");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BusinessRulesId = 6,
                            Name = "Classification 1"
                        },
                        new
                        {
                            Id = 2,
                            BusinessRulesId = 6,
                            Name = "Classification 2"
                        },
                        new
                        {
                            Id = 3,
                            BusinessRulesId = 6,
                            Name = "Classification 3"
                        },
                        new
                        {
                            Id = 4,
                            BusinessRulesId = 6,
                            Name = "Classification 4"
                        },
                        new
                        {
                            Id = 5,
                            BusinessRulesId = 7,
                            Name = "modèle horaire d'appel 1"
                        },
                        new
                        {
                            Id = 6,
                            BusinessRulesId = 6,
                            Name = "modèle horaire d'appel 2"
                        },
                        new
                        {
                            Id = 7,
                            BusinessRulesId = 6,
                            Name = "modèle horaire d'appel 3"
                        },
                        new
                        {
                            Id = 8,
                            BusinessRulesId = 6,
                            Name = "modèle horaire d'appel 4"
                        },
                        new
                        {
                            Id = 9,
                            BusinessRulesId = 10,
                            Name = "groupe de contact 1"
                        },
                        new
                        {
                            Id = 10,
                            BusinessRulesId = 10,
                            Name = "groupe de contact 2"
                        },
                        new
                        {
                            Id = 11,
                            BusinessRulesId = 10,
                            Name = "groupe de contact 3"
                        },
                        new
                        {
                            Id = 12,
                            BusinessRulesId = 10,
                            Name = "groupe de contact 4"
                        });
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.ModelBusinessRules", b =>
                {
                    b.Property<int>("ModelId")
                        .HasColumnType("int");

                    b.Property<int>("BusinessRulesId")
                        .HasColumnType("int");

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

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModelName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ModelId");

                    b.ToTable("Modeles");
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.ParameterType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ParameterTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "checkbox"
                        },
                        new
                        {
                            Id = 2,
                            Name = "dropdown"
                        },
                        new
                        {
                            Id = 3,
                            Name = "DateTime"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Number"
                        },
                        new
                        {
                            Id = 5,
                            Name = "String"
                        });
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.BusinessRules", b =>
                {
                    b.HasOne("Gestion_Regles_Affaires.Data.Models.ParameterType", "ParameterType")
                        .WithMany("BusinessRules")
                        .HasForeignKey("ParameterTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ParameterType");
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.BusinessRulesParameterValue", b =>
                {
                    b.HasOne("Gestion_Regles_Affaires.Data.Models.BusinessRules", "BusinessRules")
                        .WithMany("BusinessRulesParameterValues")
                        .HasForeignKey("BusinessRulesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BusinessRules");
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
                    b.Navigation("BusinessRulesParameterValues");

                    b.Navigation("ModelBusinessRules");
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.Modele", b =>
                {
                    b.Navigation("ModelBusinessRules");
                });

            modelBuilder.Entity("Gestion_Regles_Affaires.Data.Models.ParameterType", b =>
                {
                    b.Navigation("BusinessRules");
                });
#pragma warning restore 612, 618
        }
    }
}
