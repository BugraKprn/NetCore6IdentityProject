using EntityLayer.Concrete;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using UI.Models;

namespace UI.Controllers
{
	[AllowAnonymous]
	public class PasswordChangeController : Controller
	{
        private readonly UserManager<Student> _userManager;
        public PasswordChangeController(UserManager<Student> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult ForgetPassword()
        {
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> ForgetPassword(ForgetPasswordViewModel forgetPasswordViewModel)
		{
			var user = await _userManager.FindByEmailAsync(forgetPasswordViewModel.Mail);
			string passwordResetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
			var passwordResetTokenLink = Url.Action("ResetPassword", "PasswordChange", new
			{
				userId = user.Id,
				token = passwordResetToken
			}, HttpContext.Request.Scheme);

			MimeMessage mimeMessage = new MimeMessage();
			MailboxAddress mailboxAddressFrom = new MailboxAddress("Kprn Bank", "koparanahmetbugra@gmail.com");
			MailboxAddress mailboxAddressTo = new MailboxAddress("User", forgetPasswordViewModel.Mail);

			mimeMessage.From.Add(mailboxAddressFrom);
			mimeMessage.To.Add(mailboxAddressTo);

			var bodyBuilder = new BodyBuilder();
			bodyBuilder.TextBody = "Şifre yenileme talebinde bulundunuz. URL adresine tıklayarak yeni şifrenizi belirleyebilirsiniz." + passwordResetTokenLink;
			mimeMessage.Body = bodyBuilder.ToMessageBody();
			mimeMessage.Subject = "Şifre Sıfırlama Talebi";
			SmtpClient client = new SmtpClient();
			client.Connect("smtp.gmail.com", 587, false);
			client.Authenticate("koparanahmetbugra@gmail.com", "sjwkqyrwzvtnemzo");
			client.Send(mimeMessage);
			client.Disconnect(true);


			return View();
		}

		[HttpGet]
		public IActionResult ResetPassword(string userid, string token)
		{
			TempData["userid"] = userid;
			TempData["token"] = token;
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> ResetPassword(ResetPasswordViewModel resetPasswordViewModel)
		{
			var userid = TempData["userid"];
			var token = TempData["token"];
			if (userid == null || token == null)
			{
				// Hata Mesajı
			}
			var user = await _userManager.FindByIdAsync(userid.ToString());
			var result = await _userManager.ResetPasswordAsync(user, token.ToString(), resetPasswordViewModel.Password);
			if (result.Succeeded)
			{
				return RedirectToAction("Index", "Login");
			}
			return View();
		}
	}
}
