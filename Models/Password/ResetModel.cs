using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Password
{
    public class ResetModel
    {
        [Required]
        public string Code { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Pass must match.")]
        public string ConfirmPassword { get; set; }
    }
}