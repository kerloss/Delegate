using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    public class BookFunction
    {
        public static string GetTitle(Book B)
        {
            if (B == null) 
                return "Book object can not be null";
            return B.Title;
        }

        public static string GetAuthor(Book B)
        {
            if (B == null) 
                return "Book object can not be null";
            if (B.Authors == null || B.Authors.Length == 0)
                return "Author is not available";
            return string.Join(",", B.Authors);
        }

        public static string GetPrice(Book B)
        {
            if (B == null)
                return "Book object can not be null";
            return $"{B.Price}";
        }
    }
}
