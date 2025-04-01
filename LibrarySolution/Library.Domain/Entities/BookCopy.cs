using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities;

public class BookCopy : BaseEntity<long>
{
    public int CopyNum { get; set; }
    public bool IsAvailable { get; set; }
    public Book Book { get; set; }

    public BookCopy(Book book, int copyNum, bool isAvailable)
    {
        Book = book;
        CopyNum = copyNum;
        IsAvailable = isAvailable;
    }

    #region Overrides

    override public bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        BookCopy copy = (BookCopy)obj;
        return copy.Book.Isbn.Equals(Book.Isbn) && copy.CopyNum == CopyNum;
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }

    #endregion

    #region Methods

    public void ChangeAvailability()
    {
        IsAvailable = !IsAvailable;
    }

    #endregion

}
