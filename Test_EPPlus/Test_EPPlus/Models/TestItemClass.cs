using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test_EPPlus.Models
{
    public class TestItemClass
    {
        [Column(1)]
        public int Id { get; set; }
        [Column(2)]
        public string FullName { get; set; }

        [Column(3)]
        public string Address { get; set; }

        [Column(4)]
        public double Money { get; set; }
       
    }
}