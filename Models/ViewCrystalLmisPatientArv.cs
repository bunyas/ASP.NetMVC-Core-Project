using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewCrystalLmisPatientArv
    {
        public int? BYear { get; set; }
        public int? BMonth { get; set; }
        public int? PatientsExisting { get; set; }
        public int? PatientsNew { get; set; }
        public int? PatientNo { get; set; }
        public string RegimenClassificationDesc { get; set; }
        public int RegimenClassificationCode { get; set; }
        public string RegimenDesc { get; set; }
        public short RegimenCode { get; set; }
    }
}
