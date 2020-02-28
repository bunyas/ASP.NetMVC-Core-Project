using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistOperatorPersonal
    {
        public DistOperatorPersonal()
        {
            DistAssessmentResult = new HashSet<DistAssessmentResult>();
            DistOperatorAccident = new HashSet<DistOperatorAccident>();
            DistOperatorTraining = new HashSet<DistOperatorTraining>();
            DistVehicleCheckDefectReport = new HashSet<DistVehicleCheckDefectReport>();
            DistVehicleCheckRecommendation = new HashSet<DistVehicleCheckRecommendation>();
        }

        public string OperatorId { get; set; }
        public string Name { get; set; }
        public string StaffNumber { get; set; }
        public int? JobTitle { get; set; }
        public int? JobLocation { get; set; }
        public int? Telephone { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateEnteredService { get; set; }
        public string Address { get; set; }
        public string NextOfKin { get; set; }
        public string Residence { get; set; }
        public string MedicalCoverBenefits { get; set; }
        public string Endorsement { get; set; }
        public int? PermitCategory { get; set; }
        public DateTime? PermitDateOfIssue { get; set; }
        public DateTime? PermitExpiryDate { get; set; }
        public string AddedBy { get; set; }
        public DateTime AddedDate { get; set; }
        public string EditedBy { get; set; }
        public DateTime? EditedDate { get; set; }

        public virtual DistLocation JobLocationNavigation { get; set; }
        public virtual DistJobTitle JobTitleNavigation { get; set; }
        public virtual DistPermitCategory PermitCategoryNavigation { get; set; }
        public virtual ICollection<DistAssessmentResult> DistAssessmentResult { get; set; }
        public virtual ICollection<DistOperatorAccident> DistOperatorAccident { get; set; }
        public virtual ICollection<DistOperatorTraining> DistOperatorTraining { get; set; }
        public virtual ICollection<DistVehicleCheckDefectReport> DistVehicleCheckDefectReport { get; set; }
        public virtual ICollection<DistVehicleCheckRecommendation> DistVehicleCheckRecommendation { get; set; }
    }
}
