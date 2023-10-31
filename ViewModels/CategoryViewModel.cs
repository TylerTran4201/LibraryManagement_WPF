using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class CategoryViewModel
    {
        private void GetAllCategories(ref ObservableCollection<Category> categories) {
            ObservableCollection<Book> books = new ObservableCollection<Book>();
            Book book;
            foreach (var item in categories) {
                foreach (var item2 in item.Books) {
                    book = new Book();
                    book.Id = item2.Id;
                    book.Name = item2.Name;
                    book.Status = item2.Status;
                    book.ModifiedAt = item2.ModifiedAt;
                    book.PushlishName = item2.PushlishName;
                    book.IdAuthor = item2.IdAuthor;
                    book.CreatedAt = item2.CreatedAt;
                    book.Price = item2.Price;
                    book.Category = item2.Category;
                    books.Add(book);
                }
            }
            categories.Add(new Category("ALL", "ALL", books));
        }
        public ObservableCollection<Category> GetCategories()
        {
            ObservableCollection<Category> categories = new ObservableCollection<Category>();
            string fileName = @"Data/Books.xml";
            XmlNodeList lstNodeCategories = DataProvider.getDsNode("/Library/Category", fileName);
            XmlNodeList lstNodeBooks;
            DataProvider.Close(fileName);
            Category category;
            Book book;
            foreach (XmlNode item in lstNodeCategories)
            {
                category = new Category();
                category.Id = item.Attributes["Id"].Value;
                category.Name = item.Attributes["Name"].Value;

                lstNodeBooks = DataProvider.getDsNode(string.Format("/Library/Category[@Id='{0}']/Book", category.Id), fileName);
                foreach (XmlNode item2 in lstNodeBooks)
                {
                    if (string.Compare(item2.Attributes["Status"].Value, "1") == 0)
                    {
                        book = new Book();
                        book.Id = item2.Attributes["Id"].Value;
                        book.Name = item2.Attributes["Name"].Value;
                        book.Status = int.Parse(item2.Attributes["Status"].Value);
                        book.ModifiedAt = DateTime.Parse(item2.Attributes["ModifiedAt"].Value);
                        book.PushlishName = item2.Attributes["PushlishName"].Value;
                        book.IdAuthor = item2.Attributes["Author"].Value;
                        book.CreatedAt = DateTime.Parse(item2.Attributes["CreatedAt"].Value);
                        book.Price = int.Parse(item2.Attributes["Price"].Value);
                        book.Category = category.Id;
                        category.Books.Add(book);
                    }
                }
                categories.Add(category);
            }
            DataProvider.Close(fileName);
            GetAllCategories(ref categories);
            return categories;
        }
    }
}
