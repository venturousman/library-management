using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Members.Login;

public class LoginCommandHandler : IRequestHandler<LoginCommand, string>
{
    public async Task<string> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        // Get member

        // Check password

        // Check if refresh token is valid

        // Generate new refresh token
        // Generate new access token
        // Return access token
        throw new NotImplementedException();
    }
}
