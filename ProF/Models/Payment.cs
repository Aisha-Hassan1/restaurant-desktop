using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ProF.Models
{

    public enum type_Payment
    {
        Different_Credit_Card , Cash 
    }




    public class Payment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Payment_Id { get; set; }
        [Required]
        public type_Payment type_Payment { get; set; }
        [Required]
        [ForeignKey(nameof(order_num))]
        public int order_num { get; set; }
        [Required]
        public int Total_payment { get; set; }

        public virtual ICollection<Order>? Orders { get; set; }


    }
}
