using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class Meals
    {
        public Meals()
        {
            MealsCompositions = new HashSet<MealsCompositions>();
            RestaurantMenu = new HashSet<RestaurantMenu>();
        }

        [Column("MealID")]
        public int MealId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int Price { get; set; }

        [InverseProperty("MealNavigation")]
        public virtual ICollection<MealsCompositions> MealsCompositions { get; set; }
        [InverseProperty("MealNavigation")]
        public virtual ICollection<RestaurantMenu> RestaurantMenu { get; set; }
    }
}
