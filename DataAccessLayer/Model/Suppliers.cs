using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class Suppliers
    {
        public Suppliers()
        {
            SuppliersPerLocal = new HashSet<SuppliersPerLocal>();
            SuppliersPerProducts = new HashSet<SuppliersPerProducts>();
        }

        [Column("SupplierID")]
        public int SupplierId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        [InverseProperty("SupplierNavigation")]
        public virtual ICollection<SuppliersPerLocal> SuppliersPerLocal { get; set; }
        [InverseProperty("SupplierNavigation")]
        public virtual ICollection<SuppliersPerProducts> SuppliersPerProducts { get; set; }
    }
}
