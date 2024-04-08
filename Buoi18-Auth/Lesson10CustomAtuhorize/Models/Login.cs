using System.ComponentModel.DataAnnotations;

namespace Lesson10CustomAtuhorize.Models
{
    public class Login
    {
        [Required(ErrorMessage = "Email không được trống")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password không được trống")]
        public string Password { get; set; }
    }
}
