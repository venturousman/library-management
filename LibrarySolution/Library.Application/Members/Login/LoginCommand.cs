using MediatR;

namespace Library.Application.Members.Login;

public class LoginCommand : IRequest<string>
{
    public string Email { get; set; }
    public string Password { get; set; }
    public string? RefreshToken { get; set; }
}
