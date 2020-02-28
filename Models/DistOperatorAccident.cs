using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class DistOperatorAccident
    {
        public string DriverPermitNumber { get; set; }
        public DateTime DateOfAccident { get; set; }
        public string InjuryOperator { get; set; }
        public string InjuryOtherParty { get; set; }
        public string DamageDeptVehicle { get; set; }
        public string DamageOtherParty { get; set; }
        public string ActionTaken { get; set; }

        public virtual DistOperatorPersonal DriverPermitNumberNavigation { get; set; }
    }
}
