using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LibraryManagement
{
    public class Book : INotifyPropertyChanged
    {
        private string _Id;
        private string _Name;
        private string _IdAuthor;
        private string _PushlishName;
        private DateTime _ModifiedAt;
        private DateTime _CreatedAt;
        private int _Status;
        private string _Category;
        private int _Price;

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
        public string IdAuthor
        {
            get { return _IdAuthor; }
            set
            {
                _IdAuthor = value;
                OnPropertyChanged("IdAuthor");
            }
        }
        public string PushlishName
        {
            get { return _PushlishName; }
            set
            {
                _PushlishName = value;
                OnPropertyChanged("PushlishName");
            }
        }
        public DateTime ModifiedAt
        {
            get { return _ModifiedAt; }
            set
            {
                _ModifiedAt = value;
                OnPropertyChanged("ModifiedAt");
            }
        }
        public DateTime CreatedAt
        {
            get { return _CreatedAt; }
            set
            {
                _CreatedAt = value;
                OnPropertyChanged("CreatedAt");
            }
        }
        public int Status
        {
            get { return _Status; }
            set
            {
                _Status = value;
                OnPropertyChanged("Status");
            }
        }
        public string Category
        {
            get { return _Category; }
            set
            {
                _Category = value;
                OnPropertyChanged("Category");
            }
        }
        public int Price
        {
            get { return _Price; }
            set
            {
                _Price = value;
                OnPropertyChanged("Price");
            }
        }
        public Book(string id, string name, string IdAuthor, string puslishName, DateTime modifyAt, DateTime createdAt, int status, string category, int price)
        {
            this.Id = id;
            this.Name = name;
            this.IdAuthor = IdAuthor;
            this.PushlishName = puslishName;
            this.ModifiedAt = modifyAt;
            this.CreatedAt = createdAt;
            this.Status = status;
            this.Category = category;
            this.Price = price;
        }
        public Book(string id, string name, int status)
        {
            this.Id = id;
            this.Name = name;
        }
        public Book()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
