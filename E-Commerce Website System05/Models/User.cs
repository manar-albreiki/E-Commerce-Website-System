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
    [Table("User")]
    public class User
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int userId { get; set; } //system generated
        [Required]
        [MaxLength(50)]
        public string username { get; set; } //user input
        [Required]
        [MaxLength(50)]
        public string email { get; set; }//user input
        [Required]
        [MaxLength(256)]
        public string passwordHash { get; set; }//user input
        [Required]
        [MaxLength(100)]
        public string fullName { get; set; }//user input
         //[Optional]
        [MaxLength(20)]
        public string? phoneNumber { get; set; }//user input
        //[Optional]
        [MaxLength(300)]
        public string? address { get; set; }//user input
        [Required]
        public DateTime registrationDate { get; set; }//system generated
        public bool isActive { get; set; } = true;//default value
        public List<Order> orders { get; set; }//navigation
        public List<Review> reviews { get; set; }//navigation
    }
}
