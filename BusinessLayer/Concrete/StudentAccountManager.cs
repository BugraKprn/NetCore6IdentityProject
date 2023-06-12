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
    public class StudentAccountManager : IStudentAccountService
    {
        private readonly IStudentAccountDal _studentAccountDal;

        public StudentAccountManager(IStudentAccountDal studentAccountDal)
        {
            _studentAccountDal = studentAccountDal;
        }

        public void TDelete(StudentAccount t)
        {
            _studentAccountDal.Delete(t);
        }

        public List<StudentAccount> TGetAll()
        {
            return _studentAccountDal.GetAll();
        }

        public StudentAccount TGetById(int id)
        {
            return _studentAccountDal.GetById(id);
        }

        public void TInsert(StudentAccount t)
        {
            _studentAccountDal.Insert(t);
        }

        public void TUpdate(StudentAccount t)
        {
            _studentAccountDal.Update(t);
        }
    }
}
