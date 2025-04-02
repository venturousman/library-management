namespace Library.Application.Books.Dto;

/*
 * A record is a special type introduced in C# 9.0 that provides an immutable and value-based data model. 
 * It is often used for data transfer objects (DTOs) and models where immutability and structural equality are important.
 */
public record BookDto
{
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Isbn { get; set; } = string.Empty;
    public int MaxCheckoutLength { get; set; }
}
