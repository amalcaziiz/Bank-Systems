using Microsoft.AspNetCore.Identity;

namespace Bankssystem.Models
{
 
        public class Users : IdentityUser
        {
            public string FullName { get; set; }
        }
    }

