using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ALabCategory3
    {
        public ALabCategory3()
        {
            AProductLabCategory = new HashSet<AProductLabCategory>();
            AProductLabCategory1 = new HashSet<AProductLabCategory1>();
        }

        public int LabCat3Code { get; set; }
        public int? LabCat2Code { get; set; }
        public string LabCat3Desc { get; set; }

        public virtual ALabCategory2 LabCat2CodeNavigation { get; set; }
        public virtual ICollection<AProductLabCategory> AProductLabCategory { get; set; }
        public virtual ICollection<AProductLabCategory1> AProductLabCategory1 { get; set; }
    }
}
