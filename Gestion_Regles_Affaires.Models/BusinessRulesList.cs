using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_Regles_Affaires.Models
{
    public class BusinessRulesList
    {
        public string Name { get; set; }
        public int PersonsNumber { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int WorkHoursNumber { get; set; }
        public int PauseHoursNumber { get; set; }
        public int? MinimumHoursOutOfTotalHours { get; set; }
        public DateTime? WorkingMaximumTotalHours { get; set; }
        public int? CallBasedOnOvertime { get; set; }
        public int? CallBasedOnSeniority { get; set; }
        public int? CallBasedOnFullTimeEmployee { get; set; }
        public int? MaximumOvertime { get; set; }
        public int? MaximumWorkingHours { get; set; }
        public int? TimeBeforeShift { get; set; }
        public int? TimeAfterShift { get; set; }
        public int? AttemptNumberOfNotJoined { get; set; }
        public int? AttemptNumberOfAllContacts { get; set; }
        public int? TimeBetweenCalls { get; set; }
        public int? BroadcastPriority { get; set; }
        public string ManualContactEmails { get; set; }
        public int? CallScheduleModel { get; set; }
        public int? ContactGroupsPriorities { get; set; }
        public string EmployeeClassification { get; set; }
        public Boolean DoNotRecontactBlackListedMembersForTheSameDay { get; set; }
        public Boolean CompanyEmployeeFirst { get; set; }
        public Boolean CallDuringWorkingHoursOnly { get; set; }
        public Boolean SplitTheCall { get; set; }
        public Boolean ContinueWithTheSameList { get; set; }
        public int? ChooseAssistant { get; set; }
    }
}
