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
    [Table("")]
    public class Review
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int reviewId { get; set; } //system generated 
        [ForeignKey("user")]
        [Required]
        public int userId { get; set; } //fk
        public User user { get; set; } //navigation
        [ForeignKey("product")]
        [Required]
        public int productId { get; set; } //fk
        public Product product { get; set; } //navigation
        [Required]
        [Range(1,5)]
        public int rating { get; set; } // user inpt
        //[Optional]
        [MaxLength(1000)]
        public string? comment { get; set; } // user inpt
        [Required]
        public DateTime reviewDate { get; set; } //system generated 
    }
}
