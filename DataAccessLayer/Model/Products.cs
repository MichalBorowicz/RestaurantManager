using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class Products
    {
        public Products()
        {
            MealsCompositions = new HashSet<MealsCompositions>();
            SuppliersPerProducts = new HashSet<SuppliersPerProducts>();
        }

        [Column("ProductID")]
        public int ProductId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [InverseProperty("ProductNavigation")]
        public virtual ICollection<MealsCompositions> MealsCompositions { get; set; }
        [InverseProperty("ProductNavigation")]
        public virtual ICollection<SuppliersPerProducts> SuppliersPerProducts { get; set; }
    }
}
