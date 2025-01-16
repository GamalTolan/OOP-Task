using OOP_Task;
using System;
namespace OOP_Task;

internal class Program
{
    static void Main(string[] args)
    {
        Book book = new Book("OOP", "Gamal", "12345");

        BorrowedBook borrowedBook = new BorrowedBook(3, book, "Gamal Tolan", DateTime.Now);

        Console.WriteLine($"Book Title: {borrowedBook.BookDetails.Title}");
        Console.WriteLine($"Author: {borrowedBook.BookDetails.Author}");
        Console.WriteLine($"ISBN: {borrowedBook.BookDetails.ISBN}");
        Console.WriteLine($"Borrower: {borrowedBook.BorrowerName}");
        borrowedBook.CheckOut();
        Console.WriteLine($"Borrowing Days: {borrowedBook.CalculateBorrowDuration()}");
        borrowedBook.ReturnItem();
        borrowedBook.CheckOut();

    }
}