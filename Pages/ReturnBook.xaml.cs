using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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

namespace WPF_LibraryManagement.Pages
{
    /// <summary>
    /// Interaction logic for ReturnBook.xaml
    /// </summary>
    public partial class ReturnBook : UserControl
    {
        public ObservableCollection<CallCard> CallCards { get; set; }
        CallCardViewModel CallCardVM = new CallCardViewModel();
        Book book = new Book();
        public ReturnBook()
        {
            InitializeComponent();
        }
        private void ResetBiding() {
            this.DataContext = null;
            this.DataContext = this;
        }
        private void ResetCard() {
            lsbCurrentBook.Items.Clear();
        }
        private void IdReaderSearch_Click(object sender, RoutedEventArgs e)
        {
            txtIdCallCardWatch.Text = "";
            if (txtIdReader.Text == "")
            {
                MessageBox.Show("Reader Id cannot be left blank");
                return;
            }
            else if (CheckExistence.IdReader(txtIdReader.Text) == false)
            {
                MessageBox.Show("Reader does not exist");
                return;
            }
            CallCards = CallCardVM.GetCallCards(txtIdReader.Text);
            ResetBiding();
            txtNameReaderWatch.Text = new StringConvert().ConvertIdReaderToName(txtIdReader.Text);
            lsbCurrentBook.Items.Clear();
            if (CheckExistence.ReaderStatus(txtIdReader.Text) == true)
            {
                txtStatus.Foreground = new SolidColorBrush(Colors.Green);
                txtStatus.Text = "Active";
            }
            else
            {
                txtStatus.Foreground = new SolidColorBrush(Colors.Red);
                txtStatus.Text = "Locked";
            }
        }
        private void DtgListCallCard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ResetCard();
            txtIdBookWatch.Text = "";
            var item = dtgListCallCard.SelectedValue as CallCard;
            if (item == null)
                return;
            txtIdCallCardWatch.Text = item.Id;
            foreach (var book in item.Books)
                lsbCurrentBook.Items.Add(book);
        }
        private void CurrentCard_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as Button).DataContext as Book;
            book = item;
            txtIdBookWatch.Text = item.Name;
        }

        private void BtnReturnBook_Click(object sender, RoutedEventArgs e)
        {
            if (txtIdBookWatch.Text == "" || txtIdCallCardWatch.Text == "")
            {
                MessageBox.Show("Haven't selected the book yet");
                return;
            }
            var write1 = new CallCardXMLWrite();
            write1.ReturnBook(txtIdCallCardWatch.Text, book);
            var write2 = new StockXMLWrite();
            write2.ReturnBook(book);

            CallCards = CallCardVM.GetCallCards(txtIdReader.Text);
            lsbCurrentBook.Items.Remove(book);
            ResetBiding();

            txtIdBookWatch.Text = "";
            txtIdCallCardWatch.Text = "";

            MessageBox.Show("Successful book return");
        }
        private void Punish_Click(object sender, RoutedEventArgs e)
        {

        }



        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
