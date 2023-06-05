using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class StudentAccount
    {
        [Key]
        public int StudentAccountId { get; set; }
        public string StudentNumber { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }

    }
}
