namespace Library.Domain.Entities;

public class Checkout : BaseEntity<Guid>
{
    public List<CheckoutEntry> Entries { get; set; }
    // LibraryMember

    public Checkout()
    {
        Entries = [];
    }

    public Checkout(
        //LibraryMember member
        BookCopy bookCopy, DateTime checkoutDate, DateTime dueDate
    )
    {
        // LibraryMember = member;
        Entries = [new CheckoutEntry(this, bookCopy, checkoutDate, dueDate)];
    }

    #region Methods
    public int getNumEntries()
    {
        if (Entries == null) return 0;
        return Entries.Count;
    }
    #endregion
}
