using System.ComponentModel.DataAnnotations;

namespace Bankssystem.Models
{

    public class BankLocation
    {
       
            [Key]
            public int Id { get; set; }

            [Required]
            [StringLength(100)]
            public string? BranchName { get; set; }

            [Required]
            public string? Address { get; set; }

            [Required]
            [Phone]
            public string? PhoneNumber { get; set; }

            public DateTime? EstablishedDate { get; set; }
        }
    }


