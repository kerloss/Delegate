using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_22
{
    public class Book
    {
        public string ISBN { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public DateTime PublicationDate { get; set; }
        public decimal Price { get; set; }

        public Book(String _ISBN, string _title, string[] _authors, DateTime _publicationDate, decimal _price)
        {
            ISBN = _ISBN;
            Title = _title;
            Authors = _authors;
            PublicationDate = _publicationDate;
            Price = _price;
        }

        public override string ToString()
        {
            return $"ISBN: {ISBN}\nTitle: {Title}\nAuthor: {string.Join(",", Authors)}\nPublication Date: {PublicationDate.ToShortDateString()}\nPrice: {Price}";
        }
    }
}
