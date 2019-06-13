using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class LocalWorkers
    {
        [Column("LocalWorkersID")]
        public int LocalWorkersId { get; set; }
        public int Workers { get; set; }
        public int Locals { get; set; }
        public int HoursPerWeek { get; set; }

        [ForeignKey("Locals")]
        [InverseProperty("LocalWorkers")]
        public virtual Locals LocalsNavigation { get; set; }
        [ForeignKey("Workers")]
        [InverseProperty("LocalWorkers")]
        public virtual Workers WorkersNavigation { get; set; }
    }
}
