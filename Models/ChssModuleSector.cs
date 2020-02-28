using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class ChssModuleSector
    {
        public ChssModuleSector()
        {
            ChssComments = new HashSet<ChssComments>();
            ChssFeedBackActionArea = new HashSet<ChssFeedBackActionArea>();
            ChssFeedBackReport = new HashSet<ChssFeedBackReport>();
            ChssQuestionGuid = new HashSet<ChssQuestionGuid>();
        }

        public int SectorId { get; set; }
        public int? ModuleId { get; set; }
        public string Description { get; set; }

        public virtual ChssModule Module { get; set; }
        public virtual ICollection<ChssComments> ChssComments { get; set; }
        public virtual ICollection<ChssFeedBackActionArea> ChssFeedBackActionArea { get; set; }
        public virtual ICollection<ChssFeedBackReport> ChssFeedBackReport { get; set; }
        public virtual ICollection<ChssQuestionGuid> ChssQuestionGuid { get; set; }
    }
}
