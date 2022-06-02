using dotnet_rpg_31.Model;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace dotnet_rpg.Model
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public List<Character> Characters { get; set; }

        [Required]
        public string Role { get; set; }  
    }
}
