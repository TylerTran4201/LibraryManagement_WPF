using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LibraryManagement
{
    public class Reader : INotifyPropertyChanged
    {
        private string _Id;
        private Name _Name;
        private string _CMND;
        private DateTime _Dob;
        private string _Sex;
        private string _Email;
        private int _Status;

        public string Id
        {
            get { return _Id; }
            set
            {
                _Id = value;
                OnPropertyChanged("Id");
            }
        }
        public Name Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }
        public string CMND
        {
            get { return _CMND; }
            set
            {
                _CMND = value;
                OnPropertyChanged("CMND");
            }
        }
        public DateTime Dob
        {
            get { return _Dob; }
            set
            {
                _Dob = value;
                OnPropertyChanged("Dob");
            }
        }
        public string Sex
        {
            get { return _Sex; }
            set
            {
                _Sex = value;
                OnPropertyChanged("Sex");
            }
        }
        public string Email
        {
            get { return _Email; }
            set
            {
                _Email = value;
                OnPropertyChanged("Id");
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

        public Reader(string id, Name name, string cmnd, DateTime dob, string sex, string email)
        {
            this.Id = id;
            this.Name = name;
            this.CMND = cmnd;
            this.Dob = dob;
            this.Sex = sex;
            this.Email = email;
        }
        public Reader()
        {

        }
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
