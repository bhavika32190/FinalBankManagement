using System.ComponentModel.DataAnnotations;

namespace BankManage.Models
{
    public class BankDetails
    {
            [Key]
            public int AccountNumber { get; set; }
            public int Balance { get; set; }

        
    }
}