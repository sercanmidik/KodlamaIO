using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Entities
{
    public class Course
    {
        public int CourseId { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int InstructorId { get; set; }
        public Instructor Instructor { get; set; }
        public Category Category { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
