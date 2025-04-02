using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Application.Books.Create;

public class CreateBookCommandHandler : IRequestHandler<CreateBookCommand, long>
{
    public async Task<long> Handle(CreateBookCommand request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
