using System;
using System.Collections.Generic;

namespace EssentialJS1WebApplication1.Models
{
    public partial class FoAAuthorizedRepresentative
    {
        public FoAAuthorizedRepresentative()
        {
            FoCertificateReleaseFrmQuarantine = new HashSet<FoCertificateReleaseFrmQuarantine>();
        }

        public int ArCode { get; set; }
        public string AuthorizedRepresentativeDesc { get; set; }

        public virtual ICollection<FoCertificateReleaseFrmQuarantine> FoCertificateReleaseFrmQuarantine { get; set; }
    }
}
