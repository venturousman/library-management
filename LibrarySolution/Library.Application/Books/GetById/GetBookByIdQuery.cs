using Library.Application.Books.Dto;
using MediatR;

namespace Library.Application.Books.GetById;

public class GetBookByIdQuery : IRequest<BookDto>
{
}
