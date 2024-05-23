using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProF.Models
{
    public class Search


    {


        [Key] public int Id { get; set; }

        [ForeignKey(nameof(Recipe_num))]

        public int Recipe_num { get; set; }

        [Required]
        [ForeignKey(nameof(Recipe_Name))]

        public string Recipe_Name { get; set; }

        public virtual ICollection<Recipe>? Recipes { get; set; }
    }
}
