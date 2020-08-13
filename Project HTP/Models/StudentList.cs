using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "nvarchar(100)")]
        [DisplayName("Cover Images")]
        public string ImageName { get; set; }
        [NotMapped]
        [DisplayName("Cover Images")]
        public IFormFile ImageFile { get; set; }
    }
}
