using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ClassroomLessonManager : IClassroomLessonService
    {
        private readonly IClassroomLessonDal _classroomLessonDal;

        public ClassroomLessonManager(IClassroomLessonDal classroomLessonDal)
        {
            _classroomLessonDal = classroomLessonDal;
        }

        public void TDelete(ClassroomLesson t)
        {
            _classroomLessonDal.Delete(t);
        }

        public List<ClassroomLesson> TGetAll()
        {
            return _classroomLessonDal.GetAll();
        }

        public ClassroomLesson TGetById(int id)
        {
            return _classroomLessonDal.GetById(id);
        }

        public void TInsert(ClassroomLesson t)
        {
            _classroomLessonDal.Insert(t);
        }

        public void TUpdate(ClassroomLesson t)
        {
            _classroomLessonDal.Update(t);
        }
    }
}
