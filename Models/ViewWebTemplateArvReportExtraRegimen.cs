using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewWebTemplateArvReportExtraRegimen
    {
        public string RegimenClassificationDesc { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public int RegimenClassificationCode { get; set; }
        public short RegimenCategoryCode { get; set; }
        public string RegimenDesc { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
        public int? FacilityCode { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string OrderNumber { get; set; }
        public short RegimenCode { get; set; }
    }
}
