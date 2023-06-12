using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class ClassroomLesson
    {
        public int ClassroomId { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
        public Classroom Classroom { get; set; }
    }
}
