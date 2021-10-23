using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BankManage.Models
{
    public class UserDetails
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int AccountNumber { get; set; }

        [Required]
        public String UserName { get; set; }

        [Required]
        public String AadharNo { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public int Amount { get; set; }

        [Required]
        public String EmailId { get; set; }
        [Required]
        public String PAN { get; set; }

        [Required]
        public int Balance { get; set; }

        //[Display(Name = " Date of birth")]
        //[DataType(DataType.Date), DisplayFormat(DataFormatString =/*"{0:MM/dd/yyyy}*/",ApplyFormatInEditMode = true)]
        //[MyData(ErrorMessage = "Back date entry not allowed")]


        public DateTime? DOB   { get; set; }

    }

    public class Login
    {
        [Key]
        public int AccountNumber { get; set; }

        [Required]
        public String UserName { get; set; }


        [Required]
        public String Password { get; set; }

        
    }
}
