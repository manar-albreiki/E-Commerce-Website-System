using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerce_Website_System05.Models
{
    [Table("Product")]
    public class Product
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int productId { set; get; }//system generated
        [Required]
        [MaxLength(150)]
        public string productName { set; get; } //user input
        //[Optional]
        [MaxLength(1000)]
        public string description { set; get; }//user input
        [Required]
        [Range(0.01, double.MaxValue)]
        public decimal price { set; get; }//user input
        [Required]
        [Range(0.0, double.MaxValue)]
        public int stockQuantity { set; get; } = 0;//user input
        //[Optional]
        [MaxLength(300)]
        public string imageUrl { set; get; }//user input
        [Required]
        [ForeignKey("category")]
        public int categoryId { set; get; }  // foreign key
        public Category category { set; get; } //navigation
        [Required]
        public DateTime createdAt { set; get; } //system generated
        public bool isAvailable { set; get; } = true; //default value

        public List<Order> orders { set; get; } //navigation
        public List<Review>reviews { set; get; } //navigation


    }
}
