using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssEquipmentCategory
    {
        public ChssEquipmentCategory()
        {
            ChssEquipment = new HashSet<ChssEquipment>();
        }

        public int CatId { get; set; }
        public string CatDesc { get; set; }

        public virtual ICollection<ChssEquipment> ChssEquipment { get; set; }
    }
}
