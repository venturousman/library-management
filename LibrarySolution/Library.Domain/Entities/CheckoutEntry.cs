namespace Library.Domain.Entities;

public class CheckoutEntry : BaseEntity<Guid>
{
    public DateTime CheckoutDate { get; set; }
    public DateTime DueDate { get; set; }
    //public DateTime? ReturnDate { get; set; }
    public BookCopy BookCopy { get; set; }
    public Checkout Checkout { get; set; }

    public CheckoutEntry(Checkout checkout, BookCopy bookCopy, DateTime checkoutDate, DateTime dueDate)
    {
        Checkout = checkout;
        BookCopy = bookCopy;
        CheckoutDate = checkoutDate;
        DueDate = dueDate;
    }
}
