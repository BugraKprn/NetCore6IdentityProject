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
    public class LessonManager : ILessonService
    {
        private readonly ILessonDal _lessonDal;

        public LessonManager(ILessonDal lessonDal)
        {
            _lessonDal = lessonDal;
        }

        public void TDelete(Lesson t)
        {
            _lessonDal.Delete(t);
        }

        public List<Lesson> TGetAll()
        {
            return _lessonDal.GetAll();
        }

        public Lesson TGetById(int id)
        {
            return _lessonDal.GetById(id);
        }

        public void TInsert(Lesson t)
        {
            _lessonDal.Insert(t);
        }

        public void TUpdate(Lesson t)
        {
            _lessonDal.Update(t);
        }
    }
}
