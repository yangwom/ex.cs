using Auth.Models;

namespace Auth.ViewModels;

public class UserViewModel
{
    public User User { get; set; }
    public string Token { get; set; }
}