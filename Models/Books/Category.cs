using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LibraryManagement
{
    public class Category : INotifyPropertyChanged
    {
        private string _Id;
        private string _Name;
        private ObservableCollection<Book> _Books;

        public string Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }
        public ObservableCollection<Book> Books
        {
            get { return _Books; }
            set
            {
                _Books = value;
                OnPropertyChanged("Books");
            }
        }


        public Category(string id, string name, ObservableCollection<Book> books)
        {
            this.Id = id;
            this.Name = name;
            this.Books = books;
        }
        public Category(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Category()
        {
            this.Books = new ObservableCollection<Book>();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
