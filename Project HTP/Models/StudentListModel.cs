using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project_HTP.Models
{
    public class StudentListModel
    {
        public int StudentListId { get; set; }
        
        public string Title { get; set; }
        
        public string ShortDescription { get; set; }
        
        public string FullContent { get; set; }
        public string ImageName { get; set; }     
        public IFormFile ImageFile { get; set; }
    }
}
