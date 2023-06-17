using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    public class AppUser
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name field is required")]
        [StringLength(maximumLength:100)]
        public string UserName { get; set; }
        [Required(ErrorMessage ="Provide Email")]
        [StringLength(maximumLength:100)]
        public string Email{ get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        
    }
}