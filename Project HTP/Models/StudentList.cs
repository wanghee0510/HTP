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
        
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Tiêu đề")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Miêu tả")]
        public string ShortDescription { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Nội dung")]
        public string FullContent { get; set; }
        [Column(TypeName = "nvarchar(250)")]
        [Required(ErrorMessage = "This field is required.")]
        [DisplayName("Ảnh bìa")]
        public string CoverImg { get; set; }
    }
}
