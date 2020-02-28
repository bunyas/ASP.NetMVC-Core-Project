using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewSsmtDbqPatients
    {
        public int DistrictCode { get; set; }
        public int FacilityCode { get; set; }
        public string DistrictName { get; set; }
        public string Facility { get; set; }
        public string LevelOfCare { get; set; }
        public DateTime DateVisit { get; set; }
        public string RegimenClassificationDesc { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public string RegimenDesc { get; set; }
        public int? RegimenClassification { get; set; }
        public int? ExistingArtRegister { get; set; }
        public int? ExistingLmisReport { get; set; }
        public int? NewArtRegister { get; set; }
        public int? NewLmisReport { get; set; }
        public int? PatientDataTally { get; set; }
        public int? MaxScore { get; set; }
        public int? Score { get; set; }
    }
}
