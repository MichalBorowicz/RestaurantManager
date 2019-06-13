using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class SuppliersPerLocal
    {
        [Column("SuppliersPerLocalID")]
        public int SuppliersPerLocalId { get; set; }
        public int Supplier { get; set; }
        public int Local { get; set; }

        [ForeignKey("Local")]
        [InverseProperty("SuppliersPerLocal")]
        public virtual Locals LocalNavigation { get; set; }
        [ForeignKey("Supplier")]
        [InverseProperty("SuppliersPerLocal")]
        public virtual Suppliers SupplierNavigation { get; set; }
    }
}
