using MediatR;

namespace Library.Application.Books.Create;

public class CreateBookCommand : IRequest<long>
{
    public string Title { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int MaxCheckoutLength { get; set; }
}
