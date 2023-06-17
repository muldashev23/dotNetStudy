using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    public class AppUser
    {
        public int Id { get; set; }
        
        [StringLength(maximumLength:100)]
        public string UserName { get; set; }
        
        [StringLength(maximumLength:100)]
        public string Email{ get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public static implicit operator Barrier(AppUser v)
        {
            throw new NotImplementedException();
        }
    }
}