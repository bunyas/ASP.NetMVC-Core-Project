using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ScheduleEvent
    {
        public ScheduleEvent()
        {
            ScheduleEventFileCollection = new HashSet<ScheduleEventFileCollection>();
        }

        public string SheduleId { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public bool? AllDay { get; set; }
        public bool? Recurrence { get; set; }
        public string RecurrenceRule { get; set; }
        public string VenueCode { get; set; }
        public string City { get; set; }
        public string ParticipationInvitee { get; set; }
        public string ParticipationAttendee { get; set; }
        public string ExpectedOutput { get; set; }
        public string Objective { get; set; }
        public int? EventCategory { get; set; }
        public int? Organizer { get; set; }
        public int? MeetingType { get; set; }
        public string SourceOfFundingId { get; set; }
        public int? FundingTypeId { get; set; }
        public bool? PublicHoliday { get; set; }
        public double? CostEstimates { get; set; }
        public string ApprovedBy { get; set; }
        public DateTime? DateApproved { get; set; }
        public string AddedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public bool? EventOccured { get; set; }
        public string NoEventOccuredComment { get; set; }
        public bool? IsBlockAppointment { get; set; }
        public bool? BlockForAll { get; set; }
        public int? OrganId { get; set; }
        public int? DirectorateId { get; set; }
        public int? DeptId { get; set; }
        public string Location { get; set; }
        public int? Owner { get; set; }
        public int? Priority { get; set; }
        public string RecurrenceType { get; set; }
        public int? RecurrenceTypeCount { get; set; }
        public int? Reminder { get; set; }
        public string Categorize { get; set; }
        public string CustomStyle { get; set; }
        public DateTime? RecurrenceStartDate { get; set; }
        public DateTime? RecurrenceEndDate { get; set; }
        public string RemiderType { get; set; }
        public int? RemiderTypeCount { get; set; }
        public DateTime? RemiderStartDate { get; set; }
        public DateTime? RemiderEndDate { get; set; }
        public string RemiderRule { get; set; }
        public string VenueList { get; set; }

        public virtual ICollection<ScheduleEventFileCollection> ScheduleEventFileCollection { get; set; }
    }
}
