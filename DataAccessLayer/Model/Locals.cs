using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class Locals
    {
        public Locals()
        {
            LocalWorkers = new HashSet<LocalWorkers>();
            RestaurantMenu = new HashSet<RestaurantMenu>();
            SuppliersPerLocal = new HashSet<SuppliersPerLocal>();
        }

        [Column("LocalID")]
        public int LocalId { get; set; }
        [Required]
        [StringLength(50)]
        public string City { get; set; }
        [Required]
        [StringLength(50)]
        public string Street { get; set; }

        [InverseProperty("LocalsNavigation")]
        public virtual ICollection<LocalWorkers> LocalWorkers { get; set; }
        [InverseProperty("LocalNavigation")]
        public virtual ICollection<RestaurantMenu> RestaurantMenu { get; set; }
        [InverseProperty("LocalNavigation")]
        public virtual ICollection<SuppliersPerLocal> SuppliersPerLocal { get; set; }
    }
}
