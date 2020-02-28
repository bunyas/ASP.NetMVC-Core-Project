using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ViewPmpEmergencyProcurement
    {
        public DateTime OrderDueDate { get; set; }
        public DateTime? DateArrivalEntebbe { get; set; }
        public DateTime? DateClearedCustoms { get; set; }
        public int? NormalOrEmergencyProcurement { get; set; }
    }
}
