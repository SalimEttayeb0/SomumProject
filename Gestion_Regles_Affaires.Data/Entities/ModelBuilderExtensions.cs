using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Regles_Affaires.Data.Entities
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessRules>().HasData(
                    new BusinessRules
                    {
                        BusinessRulesId = 1,
                        Title = "Nombre de personnes",
                        Code = "PersonsNumber",
                        HasParameter = false,
                        IsRequired = true,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 2,
                        Title = "Date de début du quart de travail proposée",
                        HasParameter = false,
                        Code = "StartDate",
                        IsRequired = true,
                        ParameterTypeId = 3
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 3,
                        Title = "Date de fin du quart de travail proposée",
                        Code = "EndDate",
                        HasParameter = false,
                        IsRequired = true,
                        ParameterTypeId = 3
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 4,
                        Title = "Nombre d'heure au lieu de l'heure de fin",
                        Code = "WorkHoursNumber",
                        HasParameter = false,
                        IsRequired = true,
                        //needs to be changed to 4
                        ParameterTypeId = 3
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 5,
                        Title = "Nombre d'heures de pause",
                        Code = "PauseHoursNumber",
                        HasParameter = false,
                        IsRequired = true,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 6,
                        Title = "Classification de l'employé",
                        Code= "EmployeeClassification",
                        HasParameter = true,
                        IsRequired = true,
                        ParameterTypeId = 1
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 7,
                        Title = "Modèle horaire d'appel",
                        Code= "CallScheduleModel",
                        HasParameter = true,
                        IsRequired = false,
                        ParameterTypeId = 2
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 8,
                        Title = "Minimum sur le total heure pour les horaires normales",
                        Code = "MinimumHoursOutOfTotalHours",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 3
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 9,
                        Title = "Heure total maximum de travail",
                        Code= "WorkingMaximumTotalHours",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 3
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 10,
                        Title = "Priorisé un groupe de contacts",
                        Code="ContactGroupsPriorities",
                        HasParameter = true,
                        IsRequired = false,
                        ParameterTypeId = 2
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 11,
                        Title = "Ne pas recontacter les refusés pour le même jour",
                        Code="DoNotRecontactBlackListedMembersForTheSameDay",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 1
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 12,
                        Title = "Appeler en ordre de temps supplémentaire exécuté",
                        Code= "CallBasedOnOvertime",
                        HasParameter = false,
                        IsRequired = true,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 13,
                        Title = "Ancienneté",
                        Code= "CallBasedOnSeniority",
                        HasParameter = false,
                        IsRequired = true,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 14,
                        Title = "Employés Temps plein",
                        Code="CallBasedOnFullTimeEmployee",
                        HasParameter = false,
                        IsRequired = true,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 15,
                        Title = "Temps supplémentaire maximum",
                        Code="MaximumOvertime",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 16,
                        Title = "Maximum de temps travaillé",
                        Code="MaximumWorkingHours",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 17,
                        Title = "Temps avant le poste",
                        Code= "TimeBeforeShift",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 18,
                        Title = "Temps après le poste",
                        Code= "TimeAfterShift",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 19,
                        Title = "Employé en usine en premier",
                        Code="CompanyEmployeeFirst",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 1
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 20,
                        Title = "Appel seulement sur les heures de travail",
                        Code="CallDuringWorkingHoursOnly",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 1
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 21,
                        Title = "Appel différent sur les heures de travail",
                        Code = "ManualContactEmails",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 5
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 22,
                        Title = "Tentative des non joints",
                        Code= "AttemptNumberOfNotJoined",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 23,
                        Title = "Tentative à tous les contacts",
                        Code= "AttemptNumberOfAllContacts",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 24,
                        Title = "Division de l'appel",
                        Code= "SplitTheCall",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 1
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 25,
                        Title = "Poursuivre avec la même liste",
                        Code = "ContinueWithTheSameList",
                        HasParameter = false,
                        IsRequired = false,
                        ParameterTypeId = 1
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 26,
                        Title = "Délais entre les appels",
                        Code = "TimeBetweenCalls",
                        HasParameter = false,
                        IsRequired = false,
                        // needs to be changed to 3
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 27,
                        Title = "Priorité de la diffusion",
                        Code = "BroadcastPriority",
                        HasParameter = false,
                        IsRequired = true,
                        ParameterTypeId = 4
                    },
                    new BusinessRules
                    {
                        BusinessRulesId = 28,
                        Title= "Choisir un assistant",
                        Code ="ChooseAssistant",
                        HasParameter = true,
                        IsRequired = false,
                        ParameterTypeId = 2
                    });

            modelBuilder.Entity<ParameterType>().HasData(
                new ParameterType 
                { 
                    Id = 1,
                    Name = "checkbox",
                },
                new ParameterType
                {
                    Id = 2,
                    Name = "dropdown",
                },
                new ParameterType
                {
                    Id = 3,
                    Name = "DateTime",
                },
                new ParameterType
                {
                    Id = 4,
                    Name = "Number",
                },
                new ParameterType
                {
                    Id = 5,
                    Name = "String",
                });

            modelBuilder.Entity<BusinessRulesParameterValue>().HasData(
                new BusinessRulesParameterValue
                {
                    Id = 1,
                    Key = "class-1",
                    BusinessRulesId = 6
                },
                new BusinessRulesParameterValue
                {
                    Id = 2,
                    Key = "class-2",
                    BusinessRulesId = 6
                },
                new BusinessRulesParameterValue
                {
                    Id = 3,
                    Key = "class-3",
                    BusinessRulesId = 6
                },
                new BusinessRulesParameterValue
                {
                    Id = 4,
                    Key = "class-4",
                    BusinessRulesId = 6
                },
                new BusinessRulesParameterValue
                {
                    Id = 5,
                    Key = "mod-hor-1",
                    BusinessRulesId = 7
                },
                new BusinessRulesParameterValue
                {
                    Id = 6,
                    Key = "mod-hor-2",
                    BusinessRulesId = 7
                },
                new BusinessRulesParameterValue
                {
                    Id = 7,
                    Key = "mod-hor-3",
                    BusinessRulesId = 7
                },
                new BusinessRulesParameterValue
                {
                    Id = 8,
                    Key = "mod-hor-4",
                    BusinessRulesId = 7
                },
                new BusinessRulesParameterValue
                {
                    Id = 9,
                    Key = "group-contact-1",
                    BusinessRulesId = 10
                },
                new BusinessRulesParameterValue
                {
                    Id = 10,
                    Key = "group-contact-2",
                    BusinessRulesId = 10
                },
                new BusinessRulesParameterValue
                {
                    Id = 11,
                    Key = "group-contact-3",
                    BusinessRulesId = 10
                },
                new BusinessRulesParameterValue
                {
                    Id = 12,
                    Key = "group-contact-4",
                    BusinessRulesId = 10
                },
                new BusinessRulesParameterValue
                {
                    Id = 13,
                    Key = "assistant-1",
                    BusinessRulesId = 28
                },
                new BusinessRulesParameterValue
                {
                    Id = 14,
                    Key = "assistant-2",
                    BusinessRulesId = 28
                },
                new BusinessRulesParameterValue
                {
                    Id = 15,
                    Key = "assistant-3",
                    BusinessRulesId = 28
                },
                new BusinessRulesParameterValue
                {
                    Id = 16,
                    Key = "assistant-4",
                    BusinessRulesId = 28
                });
        }
    }
}
