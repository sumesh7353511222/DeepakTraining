using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StudentReg.Models
{
    public class StudentModel
    {
        [Required]
        [Display(Name = "Id")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Name")]
        [StringLength(50)]
        public string StudentName { get; set; }
        [Required]
        [Display(Name = "Date of Birth")]
        public DateTime DOB { get; set; }
        [Display(Name = "Address")]
       // [MaxLength()
        public string StudentAddress { get; set; }
        [Required]
        [StringLength(50)]
        //[EmailAddress]
        [CustomEmailValidator]
        [Display(Name = "Email")]
        public string StudentEmail { get; set; }
        [Required]
        [Display(Name = "Mobile No")]
        public long StudentMobileNo { get; set; }
        [Required]
        [Range(5, 50)]
        [Display(Name = "Age")]
        public int StudentAge { get; set; }
    }
}