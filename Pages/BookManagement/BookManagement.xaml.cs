using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_LibraryManagement
{
    /// <summary>
    /// Interaction logic for BookManagement.xaml
    /// </summary>
    public partial class BookManagement : UserControl
    {
        private CategoryViewModel CategoryVM = new CategoryViewModel();
        public ObservableCollection<Category> Categories { get; set; }
        private void ResetBiding() {
            this.DataContext = null;
            this.DataContext = this;
        }
        public BookManagement()
        {
            InitializeComponent();
            Categories = CategoryVM.GetCategories();
            this.DataContext = this;
        }
        private void AddNewBook_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnInfor_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as Button).DataContext as Book;
            var screen = new frmBookInfor();
            screen.Handler += delegate (ref Book book)
            {
                book = item;
            };
            screen.ShowDialog();
        }
    }
}
