using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class RestaurantMenu
    {
        [Column("RestaurantMenuID")]
        public int RestaurantMenuId { get; set; }
        public int Local { get; set; }
        public int Meal { get; set; }

        [ForeignKey("Local")]
        [InverseProperty("RestaurantMenu")]
        public virtual Locals LocalNavigation { get; set; }
        [ForeignKey("Meal")]
        [InverseProperty("RestaurantMenu")]
        public virtual Meals MealNavigation { get; set; }
    }
}
