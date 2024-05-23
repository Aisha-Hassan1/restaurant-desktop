using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProF.Models
{
    public class Category
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Cate_Id { get; set; }
        [Required]
        
        //cafe or res
        public string Cate_name { get; set; }

        public virtual ICollection<Recipe> Recipes { get; set; }
    }
}
