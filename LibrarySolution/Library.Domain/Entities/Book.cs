using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Domain.Entities;

public class Book : BaseEntity<long>
{
    // the required keyword is used to enforce that certain properties must be initialized when an object is created.
    // It is primarily used in C# 11 and later with init-only properties
    public required string Title { get; set; }
    public required string Isbn { get; set; }
    public int MaxCheckoutLength { get; set; }

    public List<BookCopy> Copies { get; set; }
    // authors

    public Book()
    {
        Copies = []; // = new List<BookCopy>();
    }

    public Book(string isbn, string title, int maxCheckoutLength)
    {
        Isbn = isbn;
        Title = title;
        MaxCheckoutLength = maxCheckoutLength;
        Copies = [new(this, 1, true)];
    }

    #region Overrides
    public override string ToString()
    {
        // Available: isAvailable()
        return $"Title: {Title}, ISBN: {Isbn}, MaxCheckoutLength: {MaxCheckoutLength}";
    }

    override public bool Equals(object? obj)
    {
        if (obj == null || GetType() != obj.GetType())
        {
            return false;
        }
        Book b = (Book)obj;
        return Isbn.Equals(b.Isbn);
    }

    public override int GetHashCode()
    {
        throw new NotImplementedException();
    }
    #endregion

    #region Methods

    public void AddCopy(BookCopy copy)
    {
        if (copy == null) return;
        var foundCopy = GetCopy(copy.CopyNum);
        if (foundCopy != null)
        {
            throw new InvalidOperationException($"Copy {copy.CopyNum} already exists for book {Isbn}");
        }
        Copies.Add(copy);
    }

    public void AddCopy()
    {
        var copy = new BookCopy(this, Copies.Count + 1, true);
        Copies.Add(copy);
    }

    public int NumberOfCopies()
    {
        return Copies.Count;
    }

    public bool IsAvailable
    {
        get
        {
            foreach (BookCopy copy in Copies)
            {
                if (copy.IsAvailable)
                {
                    return true;
                }
            }
            return false;
        }
    }

    public string AuthorNames()
    {
        return "Authors"; // TODO
    }

    public BookCopy? GetAvailableCopy()
    {
        //foreach (BookCopy copy in Copies)
        //{
        //    if (copy.IsAvailable)
        //    {
        //        return copy;
        //    }
        //}
        //return null;
        return Copies.FirstOrDefault(copy => copy.IsAvailable);
    }

    public BookCopy? GetCopy(int copyNum)
    {
        //foreach (BookCopy copy in Copies)
        //{
        //    if (copy.CopyNum == copyNum)
        //    {
        //        return copy;
        //    }
        //}
        //return null;
        return Copies.SingleOrDefault(copy => copy.CopyNum == copyNum);
    }

    #endregion
}
