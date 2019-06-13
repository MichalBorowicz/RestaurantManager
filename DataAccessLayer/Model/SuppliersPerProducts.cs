using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class SuppliersPerProducts
    {
        [Column("SuppliersPerProductsID")]
        public int SuppliersPerProductsId { get; set; }
        public int Supplier { get; set; }
        public int Product { get; set; }

        [ForeignKey("Product")]
        [InverseProperty("SuppliersPerProducts")]
        public virtual Products ProductNavigation { get; set; }
        [ForeignKey("Supplier")]
        [InverseProperty("SuppliersPerProducts")]
        public virtual Suppliers SupplierNavigation { get; set; }
    }
}
