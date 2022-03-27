using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _1911060551_NguyenThienTam_BigSchool.Models
{
    public class Course
    {
        public int Id { get; set; }
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }

        public string Place { get; set; }
        public DateTime DateTime { get; set; }  
        public Category Category { get; set; }

        public byte CategoryId { get; set; }
    }
  
}