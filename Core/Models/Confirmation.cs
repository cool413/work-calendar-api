using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    [Table("Confirmation")]
    public class Confirmation : TrackableEntry
    {
        public string Code { get; set; }
        public string SystemVersion { get; set; }

        #region Foreign key

        public int CompanyId { get; set; }

        #endregion

        #region Navigation Properties

        public virtual Company Company { get; set; }
        public virtual ICollection<CRMProgram> CRMPrograms { get; set; }
        public virtual ICollection<Job> Tasks { get; set; }

        #endregion
    }
}