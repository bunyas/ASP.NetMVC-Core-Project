using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewLmisConArvPatientNoA
    {
        public DateTime? EndDate { get; set; }
        public int? XMonth { get; set; }
        public int? XYear { get; set; }
        public int RegimenClassificationCode { get; set; }
        public short RegimenCategoryCode { get; set; }
        public short RegimenCode { get; set; }
        public string RegimenClassificationDesc { get; set; }
        public string RegimenCategoryDesc { get; set; }
        public string RegimenDesc { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
    }
}
