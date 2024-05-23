using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.ComponentModel;

namespace ProF.Models
{
    public class Recipe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Recipe_num { get; set; }
/*
       
        [ForeignKey(nameof(login_admin))]
        public int login_admin { get; set; }
        public login_admin ? login_admin { get; set; }

*/
        [Required]  
        public string Recipe_Name { get; set; }
        [Required]
        public string Recipe_Description { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]

        public float Recip_Cost { get; set; }

        [DataType(DataType.ImageUrl)]
        public string Recipe_image { get; set; }

        [Required]
       
        //التقيم بالنجم او الكومنت
        public string Evaluation { get;  set; }
       
        public virtual Order Order { get; set; }
       // public virtual login_admin login_admin { get; set; }


        public virtual Category Category { get; set; }

        public virtual Search Search { get; set; }
    }
}
