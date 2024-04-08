using System.ComponentModel.DataAnnotations;

namespace DevXuongMoc.Models.LoginModels
{
    public class LoginCustomer
    {
        public string? Name { get; set; }
        [Required(ErrorMessage = "Tên đăng nhập không được để trống")]
        public string Email { get; set; }
        [Required(ErrorMessage ="Mật khẩu không được trống")]
        public string Password { get; set; }
    }
}
