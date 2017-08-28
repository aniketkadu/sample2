using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class Emp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is a Required Field..Please Enter It..!!")]
        [DataType(DataType.Text)]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email is a Required Field..Please Enter It..!!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
      
        public string Phone { get; set; }
        [Required(ErrorMessage ="Required Field..Please Choose It..!!")]
        public bool MaritalStatus { get; set; }
       
        public int StateId { get; set; }
        
        public int CtyId { get; set; }

        public MyCty Cty { get; set; }

    }
}