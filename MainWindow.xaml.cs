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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_LibraryManagement
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void OpenNativeScreen(int mode) {
            switch (mode) {
                case 1: {
                        PagesNavigation.Navigate(new System.Uri("Pages/ReaderManagement/ReaderManagement.xaml", UriKind.RelativeOrAbsolute));
                        break;
                    }
                case 2:
                    {
                        PagesNavigation.Navigate(new System.Uri("Pages/BookManagement/BookManagement.xaml", UriKind.RelativeOrAbsolute));
                        break;
                    }
                case 3:
                    {
                        PagesNavigation.Navigate(new System.Uri("Pages/BorrowBook.xaml", UriKind.RelativeOrAbsolute));
                        break;
                    }
                case 4:
                    {
                        PagesNavigation.Navigate(new System.Uri("Pages/ReturnBook.xaml", UriKind.RelativeOrAbsolute));
                        break;
                        break;
                    }
                case 5:
                    {
                        //PagesNavigation.Navigate(new System.Uri("Pages/UCStatistical.xaml", UriKind.RelativeOrAbsolute));
                        break;
                    }
            }
           
        }
        private void RdReaderManagement_Click(object sender, RoutedEventArgs e)
        {
            OpenNativeScreen(1);
        }

        private void RdBookManagement_Click(object sender, RoutedEventArgs e)
        {
            OpenNativeScreen(2);
        }

        private void RdBorrowBooks_Click(object sender, RoutedEventArgs e)
        {
            OpenNativeScreen(3);
        }

        private void RdReturnBooks_Click(object sender, RoutedEventArgs e)
        {
            OpenNativeScreen(4);
        }

        private void RdStatistical_Click(object sender, RoutedEventArgs e)
        {
            OpenNativeScreen(5);
        }
    }
}
