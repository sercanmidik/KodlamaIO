﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Category
    {
        public int  CategoryId { get; set; }
        public string Name { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}
