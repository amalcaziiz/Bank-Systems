using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Bankssystem.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string? AccountNumber { get; set; }
        public decimal Balance { get; set; }
    }


}

