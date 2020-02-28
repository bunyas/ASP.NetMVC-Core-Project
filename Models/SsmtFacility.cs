using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class SsmtFacility
    {
        public SsmtFacility()
        {
            SsmtAreaVisited = new HashSet<SsmtAreaVisited>();
            SsmtComment = new HashSet<SsmtComment>();
            SsmtFacilitySummaryScore = new HashSet<SsmtFacilitySummaryScore>();
            SsmtIndicator = new HashSet<SsmtIndicator>();
            SsmtJointVisit = new HashSet<SsmtJointVisit>();
            SsmtPersonnel = new HashSet<SsmtPersonnel>();
            SsmtRptIndicator = new HashSet<SsmtRptIndicator>();
            SsmtStockManagementPractices = new HashSet<SsmtStockManagementPractices>();
            SsmtStockManagementPracticesLab = new HashSet<SsmtStockManagementPracticesLab>();
            SsmtStockManagementTools = new HashSet<SsmtStockManagementTools>();
            SsmtStockManagementToolsLab = new HashSet<SsmtStockManagementToolsLab>();
            SsmtSubmittedDocuments = new HashSet<SsmtSubmittedDocuments>();
            SsmtVerificationLmisData = new HashSet<SsmtVerificationLmisData>();
            SsmtVerificationLmisDataLab = new HashSet<SsmtVerificationLmisDataLab>();
            SsmtVerificationPatientData = new HashSet<SsmtVerificationPatientData>();
            SsmtVisitPurpose = new HashSet<SsmtVisitPurpose>();
        }

        public int FacilityId { get; set; }
        public DateTime DateVisit { get; set; }
        public bool? AccreditedArt { get; set; }
        public DateTime? DateNextVisit { get; set; }
        public string AddedBy { get; set; }
        public DateTime? DateAdded { get; set; }
        public string EditedBy { get; set; }
        public DateTime? DateEdited { get; set; }
        public bool? ReadinessArt { get; set; }
        public int? SiteVolume { get; set; }
        public string VisitMajorIssue { get; set; }
        public int? Ssmts { get; set; }

        public virtual AFacilities Facility { get; set; }
        public virtual SsmtASiteVolume SiteVolumeNavigation { get; set; }
        public virtual SsmtASsmts SsmtsNavigation { get; set; }
        public virtual ICollection<SsmtAreaVisited> SsmtAreaVisited { get; set; }
        public virtual ICollection<SsmtComment> SsmtComment { get; set; }
        public virtual ICollection<SsmtFacilitySummaryScore> SsmtFacilitySummaryScore { get; set; }
        public virtual ICollection<SsmtIndicator> SsmtIndicator { get; set; }
        public virtual ICollection<SsmtJointVisit> SsmtJointVisit { get; set; }
        public virtual ICollection<SsmtPersonnel> SsmtPersonnel { get; set; }
        public virtual ICollection<SsmtRptIndicator> SsmtRptIndicator { get; set; }
        public virtual ICollection<SsmtStockManagementPractices> SsmtStockManagementPractices { get; set; }
        public virtual ICollection<SsmtStockManagementPracticesLab> SsmtStockManagementPracticesLab { get; set; }
        public virtual ICollection<SsmtStockManagementTools> SsmtStockManagementTools { get; set; }
        public virtual ICollection<SsmtStockManagementToolsLab> SsmtStockManagementToolsLab { get; set; }
        public virtual ICollection<SsmtSubmittedDocuments> SsmtSubmittedDocuments { get; set; }
        public virtual ICollection<SsmtVerificationLmisData> SsmtVerificationLmisData { get; set; }
        public virtual ICollection<SsmtVerificationLmisDataLab> SsmtVerificationLmisDataLab { get; set; }
        public virtual ICollection<SsmtVerificationPatientData> SsmtVerificationPatientData { get; set; }
        public virtual ICollection<SsmtVisitPurpose> SsmtVisitPurpose { get; set; }
    }
}
