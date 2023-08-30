using System.ComponentModel.DataAnnotations;
using API.Extensions;
using Microsoft.EntityFrameworkCore;

namespace API.Entities
{
    [Index(nameof(Email), IsUnique = true)]
    public class AppUser
    {
        public int Id { get; set; }

        [StringLength(maximumLength: 100)]
        public string UserName { get; set; }

        [StringLength(maximumLength: 100)]
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public DateOnly DateOfBirth { get; set; }
        public string KnownAs { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime LastActive { get; set; } = DateTime.Now;
        public string Gender { get; set; }
        public string Introduction { get; set; }
        public string Interests { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public List<Photo> Photos { get; set; } = new();
    }
}
