using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Lesson
    {
        [Key]
        public int LessonId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public ICollection<LessonSubject> Subjects { get; set; }
        public ICollection<ClassroomLesson> Classrooms { get; set; }

    }
}
