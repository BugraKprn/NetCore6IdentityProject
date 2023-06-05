using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Student : IdentityUser<int>
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public string ImageUrl { get; set; }
        public string Adresss { get; set; }
        public int ConfirmCode { get; set; }
        public Classroom Classroom { get; set; }
        public StudentAccount StudentAccount { get; set; }
    }
}
