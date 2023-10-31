using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LibraryManagement
{
    public class ViewCallCard
    {

        public string Id { get; set; }
        public string IdReader { get; set; }
        public string BorrowDate { get; set; }
        public string ReturnDate { get; set; }
        public int Status { get; set; }
        public Book Book { get; set; }
        public ViewCallCard(string id, string idReader, DateTime borrowDate, DateTime returnDate, int status, Book book)
        {
            this.Id = id;
            this.IdReader = idReader;
            this.BorrowDate = borrowDate.ToString("MM/dd/yyyy");
            this.ReturnDate = returnDate.ToString("MM/dd/yyyy");
            this.Status = status;
            this.Book = book;
        }
        public ViewCallCard(string id, string idReader, DateTime borrowDate, DateTime returnDate, int quantity, int status)
        {
            this.Id = id;
            this.IdReader = idReader;
            this.BorrowDate = borrowDate.ToString("MM/dd/yyyy");
            this.ReturnDate = returnDate.ToString("MM/dd/yyyy");
            this.Status = status;
        }
        public ViewCallCard()
        {

        }
    }
}
