using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Website_System05.Models
{
    [Table("OrderItems")]
    public class OrderItem

    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int orderItemId { get; set; }// system generated


        // relationship attribute — carried by this bridge entity
        [Required]
        [Range(1, 999)]
        public int quantity { get; set; }// user input


        // foreign key — every order item belongs to exactly one order
        [Required]
        [ForeignKey("order")]
        public int orderId { get; set; }// system generated — from the active order
        public virtual Order order { get; set; }// navigation property

        // foreign key — every order item references exactly one product
        [Required]
        [ForeignKey("product")]
        public int productId { get; set; } // from list — chosen from available products
        public virtual Product product { get; set; } // navigation property

        [Required]
        [Column(TypeName = "decimal(10,2)")]
        public decimal unitPrice { get; set; }            // calculated — copied from product.price at the time of ordering



    }
}
