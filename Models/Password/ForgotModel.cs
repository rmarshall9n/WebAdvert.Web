using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Password
{
    public class ForgotModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}