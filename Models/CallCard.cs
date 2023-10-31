using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LibraryManagement
{
    public class CallCard
    {
        public string Id { get; set; }
        public string IdReader { get; set; }
        public DateTime BorrowDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public int Quantity { get; set; }
        public List<Book> Books { get; set; }
        public CallCard(string id, string idReader, DateTime borrowDate, DateTime returnDate, int quantity, List<Book> books)
        {
            this.Id = id;
            this.IdReader = idReader;
            this.BorrowDate = borrowDate;
            this.ReturnDate = returnDate;
            this.Quantity = quantity;
            this.Books = books;
        }
        public CallCard()
        {

        }
    }
}
