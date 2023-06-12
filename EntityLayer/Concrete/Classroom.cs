using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Classroom
    {
        [Key]
        public int ClassroomId { get; set; }
        public string Year { get; set; }
        public string Class { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<ClassroomLesson> Lessons { get; set; }
    }
}
