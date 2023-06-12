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
    public class ClassroomManager : IClassroomService
    {
        private readonly IClassroomDal _classroomDal;

        public ClassroomManager(IClassroomDal classroomDal)
        {
            _classroomDal = classroomDal;
        }

        public List<Classroom> GetListByStudent(int id)
        {
            return _classroomDal.GetListByFilter(X => X.ClassroomId == id);
        }

        public void TDelete(Classroom t)
        {
            _classroomDal.Delete(t);
        }

        public List<Classroom> TGetAll()
        {
            return _classroomDal.GetAll();
        }

        public Classroom TGetById(int id)
        {
            return _classroomDal.GetById(id);
        }

        public void TInsert(Classroom t)
        {
            _classroomDal.Insert(t);
        }

        public void TUpdate(Classroom t)
        {
            _classroomDal.Update(t);
        }
    }
}
