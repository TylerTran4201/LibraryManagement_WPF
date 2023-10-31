using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LibraryManagement
{
    public class Author : INotifyPropertyChanged
    {
        private string _Id;
        private string _Name;
        private bool _IsCheck;
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

        public bool IsCheck
        {
            get { return _IsCheck; }
            set
            {
                _IsCheck = value;
                OnPropertyChanged("IsCheck");
            }
        }
        public Author(string id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
        public Author()
        {

        }

        public event PropertyChangedEventHandler PropertyChanged;
        // Create the OnPropertyChanged method to raise the event
        // The calling member's name will be used as the parameter.
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
