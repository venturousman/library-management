using Library.Application.Books.Dto;
using MediatR;

namespace Library.Application.Books.GetById;

public class GetBookByIdQueryHandler : IRequestHandler<GetBookByIdQuery, BookDto>
{
    public Task<BookDto> Handle(GetBookByIdQuery request, CancellationToken cancellationToken)
    {
        //throw new NotImplementedException();
        return Task.FromResult(new BookDto());
    }
}
