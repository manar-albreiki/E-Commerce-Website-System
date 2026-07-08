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
    [Table("Category")]
    public class Category
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int categoryId { get; set; } //system generated
        [Required]
        [MaxLength(100)]
        public string categoryName { get; set; } //user input
        //[Optional]
        [MaxLength(500)]
        public string? description { get; set; } //user input 
        //[Optional]
        [MaxLength(300)]
        public string? imageUrl { get; set; } //user input

        public virtual List<Product> products { get; set; } //navigation

    }
}
