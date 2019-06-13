using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class Workers
    {
        public Workers()
        {
            LocalWorkers = new HashSet<LocalWorkers>();
        }

        [Column("WorkerID")]
        public int WorkerId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string Surname { get; set; }
        [Required]
        [Column("PESEL")]
        [StringLength(50)]
        public string Pesel { get; set; }

        [InverseProperty("WorkersNavigation")]
        public virtual ICollection<LocalWorkers> LocalWorkers { get; set; }
    }
}
