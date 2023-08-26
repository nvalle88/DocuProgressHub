#region Using

using System.ComponentModel.DataAnnotations;
using SmartAdminSaludsa.Utils;

#endregion

namespace SmartAdminSaludsa.Models
{
    public class RegisterOnlineViewModel
    {

        [Required(ErrorMessage =Validaciones.Requerido)]
        [EmailAddress(ErrorMessage =Validaciones.FormatoCorreo)]
        [Display(Name = "Correo electrónico")]
        [StringLength(maximumLength:50,ErrorMessage =Validaciones.LongitudString)]
        public string Email { get; set; }

        [Required(ErrorMessage = Validaciones.Requerido)]
        [EmailAddress(ErrorMessage = Validaciones.FormatoCorreo)]
        [Display(Name = "Confirmar Correo electrónico")]
        [StringLength(maximumLength: 50, ErrorMessage = Validaciones.LongitudString)]
        [Compare("Email", ErrorMessage= "Confirmar Correo no coincide con el Correo electrónico")]
        public string EmailConfirm { get; set; }

        [Required(ErrorMessage = Validaciones.Requerido)]
        [Display(Name = "Contraseña")]
        [StringLength(maximumLength: 20, ErrorMessage = Validaciones.LongitudString)]
        public string Password { get; set; }

        [Required(ErrorMessage = Validaciones.Requerido)]
        [Display(Name = "Confirmar Contraseña")]
        [StringLength(maximumLength: 20, ErrorMessage = Validaciones.LongitudString)]
        [Compare("Password", ErrorMessage = "Confirmar Contraseña no coincide con la Contraseña")]
        public string PasswordConfirm { get; set; }

        [Required(ErrorMessage = Validaciones.Requerido)]
        [Display(Name = "Nombre")]
        [StringLength(maximumLength: 256, ErrorMessage = Validaciones.LongitudString)]
        public string Name { get; set; }

        [Required(ErrorMessage = Validaciones.Requerido)]
        [Display(Name = "Apellidos")]
        [StringLength(maximumLength: 100, ErrorMessage = Validaciones.LongitudString)]
        public string LastName { get; set; }

        [Required(ErrorMessage = Validaciones.Requerido)]
        [Display(Name = "Teléfono")]
        [StringLength(maximumLength: 10, ErrorMessage = Validaciones.LongitudString)]
        public string PhoneNumber { get; set; }
    }
}
