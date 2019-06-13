using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccessLayer.Model
{
    public partial class MealType
    {
        public MealType()
        {
            MealsCompositions = new HashSet<MealsCompositions>();
        }

        [Column("MealID")]
        public int MealId { get; set; }
        [Required]
        [StringLength(50)]
        public string Type { get; set; }

        [InverseProperty("MealTypeNavigation")]
        public virtual ICollection<MealsCompositions> MealsCompositions { get; set; }
    }
}
