using System.ComponentModel.DataAnnotations;

namespace TraversalCoreProject.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Ad Kısmı Zorunludur!")]
		public string Name { get; set; }


		[Required(ErrorMessage = "Soyad Kısmı Zorunludur!")]
		public string Surname { get; set; }


		[Required(ErrorMessage = "Kullanıcı Ad Kısmı Zorunludur!")]
		public string UserName { get; set; }


		[Required(ErrorMessage = "Mail Kısmı Zorunludur!")]
		public string Mail { get; set; }

		[Required(ErrorMessage = "Şifre Kısmı Zorunludur!")]
		public string Password { get; set; }


		[Required(ErrorMessage = "Şifre Tekrar Kısmı Zorunludur!")]
		[Compare("Password",ErrorMessage="Şifre Uyumlu Değil.")]
		public string ConfirmPassword { get; set; }



	}
}
