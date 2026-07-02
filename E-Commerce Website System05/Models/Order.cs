using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Website_System05.Models
{
    [Table("Order")]
    public class Order
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderId { get; set; } //system generated
        [Required]
        [ForeignKey("user")]
        public int userId { get; set; } //fk
        public User user { get; set; } //navigation
        [Required]
        public DateTime orderDate { get; set; } //system generated
        [Required]
        [Range(0.0,double.MaxValue)]
        public decimal totalAmount { get; set; } //calculated
        [Required]
        [MaxLength(30)]
        public string status { get; set; } = "Pending"; //default value
        [Required]
        [MaxLength(300)]
        public string shippingAddress { get; set; } // user input
        [Required]
        [MaxLength(50)]
        public string paymentMethod { get; set; } // user input

        public List<Product> products { get; set; } //navigation

    }
}
