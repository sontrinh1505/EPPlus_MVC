using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Test_EPPlus.Models
{
    public class ExcelResourceDto
    {
        [Column(1)]
        [Required]
        public string Title { get; set; }

        [Column(2)]
        [Required]
        public string SearchTags { get; set; }
    }


    public class ExcelResourceDtoTest
    {
        [Column(1)]
        [Required]
        public string Id { get; set; }

        [Column(2)]
        [Required]
        public string FullName { get; set; }

        [Column(3)]
        [Required]
        public string Address { get; set; }

        [Column(4)]
        [Required]
        public double Money { get; set; }

       
    }
}