using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project_HTP.Models
{
    public class StudentList
    {
        [Key]
        public int StudentListId { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ShortDescription { get; set; }
        [Required]
        public string FullContent { get; set; }
        [Required]
        public string CoverImg { get; set; }
    }
}
