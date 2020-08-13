using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_HTP.Models
{
    public class LoginUser
    {
        [Key]
        public int LoginID { get; set; }
        [Required]
        public string Account { get; set; }
        [Required]
        public string Password { get; set; }
        public string NameUser { get; set; }
    }
}
