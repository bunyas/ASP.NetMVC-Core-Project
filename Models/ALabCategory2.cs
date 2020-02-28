using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ALabCategory2
    {
        public ALabCategory2()
        {
            ALabCategory3 = new HashSet<ALabCategory3>();
            AProductLabCategory = new HashSet<AProductLabCategory>();
        }

        public int LabCat2Code { get; set; }
        public int? LabCat1Code { get; set; }
        public string LabCat2Desc { get; set; }

        public virtual ALabCategory1 LabCat1CodeNavigation { get; set; }
        public virtual ICollection<ALabCategory3> ALabCategory3 { get; set; }
        public virtual ICollection<AProductLabCategory> AProductLabCategory { get; set; }
    }
}
