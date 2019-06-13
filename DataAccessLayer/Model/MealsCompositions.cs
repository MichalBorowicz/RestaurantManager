using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class MealsCompositions
    {
        [Column("MealsCompositionsID")]
        public int MealsCompositionsId { get; set; }
        public int Meal { get; set; }
        public int Product { get; set; }
        public int MealType { get; set; }

        [ForeignKey("Meal")]
        [InverseProperty("MealsCompositions")]
        public virtual Meals MealNavigation { get; set; }
        [ForeignKey("MealType")]
        [InverseProperty("MealsCompositions")]
        public virtual MealType MealTypeNavigation { get; set; }
        [ForeignKey("Product")]
        [InverseProperty("MealsCompositions")]
        public virtual Products ProductNavigation { get; set; }
    }
}
