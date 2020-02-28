using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ADrugFormulation
    {
        public ADrugFormulation()
        {
            PhysicalCountDetails = new HashSet<PhysicalCountDetails>();
        }

        public int DrugCode { get; set; }
        public short? DrugFormulationCode { get; set; }
        public string DosageFormulatioCode { get; set; }
        public string VisibleCode { get; set; }
        public string DrugDesc { get; set; }
        public double? OptimalConsumptionRate { get; set; }
        public short? BasicUnit { get; set; }
        public int? PackSize { get; set; }
        public int? PillsPerDose { get; set; }
        public double? NrtiRatio { get; set; }
        public double? NnrtiRatio { get; set; }
        public double? PiRatio { get; set; }
        public short? RegimenCode { get; set; }
        public string RegimenCombination { get; set; }

        public virtual ADrugBasicUnit BasicUnitNavigation { get; set; }
        public virtual ADrugFormulationCode DrugFormulationCodeNavigation { get; set; }
        public virtual ICollection<PhysicalCountDetails> PhysicalCountDetails { get; set; }
    }
}
