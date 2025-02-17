using System.ComponentModel.DataAnnotations;

namespace ClienteAPI.DTOs;

public class LoginModel
{
    [Required(ErrorMessage ="Usuario é obrigatório.")]
    public string? UserName { get; set; }

    [Required(ErrorMessage = "Senha é obrigatório.")]
    public string? Password { get; set; }
}
