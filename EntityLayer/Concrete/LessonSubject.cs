using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class LessonSubject
    {
        public int LessonSubjectId { get; set; }
        public string SubjectName { get; set; }
        public string SubjectIcon { get; set; }

        //Lesson
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
