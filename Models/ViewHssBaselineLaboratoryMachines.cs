using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewHssBaselineLaboratoryMachines
    {
        public int? Category2Code { get; set; }
        public int? Category3Code { get; set; }
        public int ProductCategoryCode { get; set; }
        public int? ProductCode { get; set; }
        public string LabCat1Desc { get; set; }
        public string LabCat2Desc { get; set; }
        public string LabCat3Desc { get; set; }
        public string ProductDescription { get; set; }
        public string AvialabilityServiceContract { get; set; }
        public string ServiceProvider { get; set; }
        public string ServiceFrequency { get; set; }
        public string Remarks { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? InterviewDate { get; set; }
    }
}
