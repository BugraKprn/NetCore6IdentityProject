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
    public class LessonSubjectManager : ILessonSubjectService
    {
        private readonly ILessonSubjectDal _lessonSubjectDal;

        public LessonSubjectManager(ILessonSubjectDal lessonSubjectDal)
        {
            _lessonSubjectDal = lessonSubjectDal;
        }

        public void TDelete(LessonSubject t)
        {
            _lessonSubjectDal.Delete(t);
        }

        public List<LessonSubject> TGetAll()
        {
            return _lessonSubjectDal.GetAll();
        }

        public LessonSubject TGetById(int id)
        {
            return _lessonSubjectDal.GetById(id);
        }

        public void TInsert(LessonSubject t)
        {
            _lessonSubjectDal.Insert(t);
        }

        public void TUpdate(LessonSubject t)
        {
            _lessonSubjectDal.Update(t);
        }
    }
}
