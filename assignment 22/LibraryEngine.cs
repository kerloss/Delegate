using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    //Define delegate with signature of BookFunction methods
    public delegate string BookDelegate(Book B);

    public class LibraryEngine
    {
        public static void ProcessBooks(List<Book> bList,BookDelegate fPtr)
        {
            foreach (Book B in bList)
            {
                Console.WriteLine(fPtr(B));
            }
        }
    } 
}
