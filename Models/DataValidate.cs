//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Web;

//namespace BankManage.Models
//{
//    public class MyDataAttribute : ValidationAttribute
//    {
//        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
//        {

//            DateTime _dateJoin = Convert.ToDateTime(value);
//            if (_dateJoin >= DateTime.Now)
//            {
//                return ValidationResult.Success;
//            }
//            else
//            {
//                return new ValidationResult(ErrorMessage);
//            }
//        }
//    }
//}