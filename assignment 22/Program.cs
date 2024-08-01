using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection.Metadata;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Runtime.Intrinsics.X86;
using System.Collections;

namespace assignment_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            //1.Considering the Code Below, Write Down the Body of all Listed Methods and Properties and Constructor:
            //1.You need to parameterize ProcessBooks function to accept BookFunctions Methods using following cases:
            //a)	Create User Defined Delegate with the same signature of methods existed in Bookfunctions class.
            //b)	Use the Proper build in delegate.
            //c)    Anonymous Method(GetISBN).
            //d)	Lambda Expression(GetPublicationDate).

            //List<Book> books = new List<Book>
            //{
            //    new Book("01210810875", "C#", new string[] { "Wale", "Ahmed" }, new DateTime(1988, 5, 12), 15),
            //    new Book("01234568955", "C++", new string[] { "Andrew", "David" }, new DateTime(2024, 8, 1), 20),
            //    new Book("01230545455", "Java", new string[] { "Kerloss" }, new DateTime(2020, 8, 1), 30)
            //};

            ////a. User-defined delegate
            //LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunction.GetTitle));
            //LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunction.GetAuthor));
            //LibraryEngine.ProcessBooks(books, new BookDelegate(BookFunction.GetPrice));

            ////b. Using a built-in delegate
            //LibraryEngine.ProcessBooks(books, BookFunction.GetTitle);
            //LibraryEngine.ProcessBooks(books, BookFunction.GetAuthor);
            //LibraryEngine.ProcessBooks(books, BookFunction.GetPrice);

            ////c. Using an anonymous method for GetISBN
            //LibraryEngine.ProcessBooks(books, delegate (Book b) { return b.ISBN; });

            ////d. Using a lambda expression for GetPublicationDate
            //LibraryEngine.ProcessBooks(books, b => b.PublicationDate.ToString());
            #endregion


            #region Part 2

            //1.	We need to Implement the List methods from scratch with all overloads.
            //●	Exist
            //●	Find
            //●	Find All
            //●	Find index
            //●	Find Last
            //●	Find Last Index
            //●	Foreach
            //●	TrueForAll

            
            #endregion
        }
    }
}
