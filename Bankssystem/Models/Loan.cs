using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bankssystem.Models
{
    public class Loan
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("Customer")]
        public int CustomerId { get; set; }

        public string? CustomerEmail { get; set; }

        [Required]
        [Range(1000.0, double.MaxValue)]
        public decimal? LoanAmount { get; set; }

        [Required]
        public decimal? InterestRate { get; set; }

        [Required]
        public int? TermInMonths { get; set; }

        public DateTime? StartDate { get; set; }
    }
}
