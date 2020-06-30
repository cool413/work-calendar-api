using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.Models
{
    [Table("Employee")]
    public class Employee : TrackableEntry
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }

        #region Navigation Properties

        public virtual ICollection<CRMProgram> CRMPrograms { get; set; }
        public virtual ICollection<Job> Tasks { get; set; }

        #endregion
    }
}