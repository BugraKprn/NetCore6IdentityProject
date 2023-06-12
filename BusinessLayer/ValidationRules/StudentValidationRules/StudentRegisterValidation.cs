using DtoLayer.Dtos.Student;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules.StudentValidationRules
{
    public class StudentRegisterValidation : AbstractValidator<StudentRegisterDto>
    {
        public StudentRegisterValidation()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Ad alanı boş bırakılamaz !");
            RuleFor(x => x.Name).MaximumLength(30).WithMessage("Lütfen en fazla 30 karakter giriniz !");
            RuleFor(x => x.Name).MinimumLength(2).WithMessage("Lütfen en az 2 karakter giriniz !");


            RuleFor(x => x.SurName).NotEmpty().WithMessage("Soyad alanı boş bırakılamaz !");
            RuleFor(x => x.Username).NotEmpty().WithMessage("Kullanıcı adı alanı boş bırakılamaz !");


            RuleFor(x => x.Email).NotEmpty().WithMessage("Mail alanı boş bırakılamaz !");
            RuleFor(x => x.Email).EmailAddress().WithMessage("Lütfen geçerli bir mail adresi giriniz !");


            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre alanı boş bırakılamaz !");


            RuleFor(x => x.ConfirmPassword).NotEmpty().WithMessage("Şifre tekrar alanı boş bırakılamaz !");
            RuleFor(x => x.ConfirmPassword).Equal(y => y.Password).WithMessage("Şifreler uyuşmuyor !");


        }
    }
}
