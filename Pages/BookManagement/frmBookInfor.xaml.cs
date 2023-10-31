using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPF_LibraryManagement
{
    /// <summary>
    /// Interaction logic for frmBookInfor.xaml
    /// </summary>
    public partial class frmBookInfor : Window
    {
        public delegate void MyDelegate(ref Book book);
        public event MyDelegate Handler;
        public Book book { get; set; }
        public frmBookInfor()
        {
            InitializeComponent();
            this.DataContext = book;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Handler != null)
            {
                Book booktemp = new Book();
                Handler(ref booktemp);
                book = booktemp;
                book.IdAuthor = new StringConvert().ConvertIdToName(book.IdAuthor);
                this.DataContext = book;
            }
        }
        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
