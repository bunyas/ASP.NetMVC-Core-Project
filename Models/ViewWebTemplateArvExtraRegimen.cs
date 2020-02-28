using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateArvExtraRegimen
    {
        public int RegimenClassificationCode { get; set; }
        public short RegimenCategoryCode { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public string RegimenClassificationDesc { get; set; }
        public string RegimenDesc { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
        public int? PregnantExisting { get; set; }
        public int? PregnantNew { get; set; }
        public int? ExistingPatients { get; set; }
        public int? NewPatients { get; set; }
        public short RegimenCode { get; set; }
        public bool? StandardRegimen { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
