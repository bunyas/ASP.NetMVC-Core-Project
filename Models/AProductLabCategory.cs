using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class AProductLabCategory
    {
        public AProductLabCategory()
        {
            OrderLab = new HashSet<OrderLab>();
            OrderLabAmc = new HashSet<OrderLabAmc>();
            OrderLabEmergency = new HashSet<OrderLabEmergency>();
            OrderLabPhysicalCount = new HashSet<OrderLabPhysicalCount>();
            SsmtStockManagementPracticesLab = new HashSet<SsmtStockManagementPracticesLab>();
            SsmtStockManagementToolsLab = new HashSet<SsmtStockManagementToolsLab>();
            SsmtVerificationLmisDataLab = new HashSet<SsmtVerificationLmisDataLab>();
        }

        public int ProductCategoryCode { get; set; }
        public int? ProductCode { get; set; }
        public int? Category2Code { get; set; }
        public int? Category3Code { get; set; }

        public virtual ALabCategory2 Category2CodeNavigation { get; set; }
        public virtual ALabCategory3 Category3CodeNavigation { get; set; }
        public virtual ICollection<OrderLab> OrderLab { get; set; }
        public virtual ICollection<OrderLabAmc> OrderLabAmc { get; set; }
        public virtual ICollection<OrderLabEmergency> OrderLabEmergency { get; set; }
        public virtual ICollection<OrderLabPhysicalCount> OrderLabPhysicalCount { get; set; }
        public virtual ICollection<SsmtStockManagementPracticesLab> SsmtStockManagementPracticesLab { get; set; }
        public virtual ICollection<SsmtStockManagementToolsLab> SsmtStockManagementToolsLab { get; set; }
        public virtual ICollection<SsmtVerificationLmisDataLab> SsmtVerificationLmisDataLab { get; set; }
    }
}
