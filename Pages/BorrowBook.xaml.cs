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

namespace WPF_LibraryManagement.Pages
{
    /// <summary>
    /// Interaction logic for BorrowBook.xaml
    /// </summary>
    public partial class BorrowBook : UserControl
    {
        ObservableCollection<CallCard> CallCards { get; set; }
        public List<ViewCallCard> ViewCallCards { get; set; }
        CallCardViewModel CallCardVM = new CallCardViewModel();
        List<Stock> Stocks { get; set; }
        Regulation Regulation = new RegulationViewModel().GetRegulation();
        List<Stock> StocksTemp = new List<Stock>();
        public BorrowBook()
        {
            InitializeComponent();
            this.DataContext = this;
        }
        private void ResetBiding()
        {
            ViewCallCards = CallCardVM.GetViewCallCards(CallCards);
            this.DataContext = null;
            this.DataContext = this;
        }
        private void ResetCard()
        {
            lsbCurrentBook.Items.Clear();
            lsbBorrowBook.Items.Clear();
            foreach (var item in Stocks)
            {
                lsbCurrentBook.Items.Add(item);
            }

        }
        private int count = 0;
        private void IdReaderSearch_Click(object sender, RoutedEventArgs e)
        {
            count = 0; // reset
            StocksTemp.Clear(); // reset
            if (txtIdReader.Text == "")
            {
                MessageBox.Show("Không Được để trống Id đọc giả");
                return;
            }
            else if (CheckExistence.IdReader(txtIdReader.Text) == false)
            {
                MessageBox.Show("Id đọc giả không tồn tại");
                return;
            }
            CallCards = CallCardVM.GetCallCards(txtIdReader.Text);
            if (CallCards == null)
                count = 0;
            else
            {
                foreach (var item in CallCards)
                {
                    count += item.Books.Count;
                }
            }
            ResetBiding();
            Stocks = new StockViewModel().GetStocks();
            ResetCard();
        }

        private void BookSearch_Click(object sender, RoutedEventArgs e)
        {
            var view = new ObservableCollection<Book>();
            if (txtBookSearch.Text != "")
            {
                lsbCurrentBook.Items.Clear();
                foreach (var item in Stocks)
                {
                    if (item.Name.Contains(txtBookSearch.Text))
                        lsbCurrentBook.Items.Add(item);
                }
                if (lsbCurrentBook.Items.Count == 0)
                {
                    ResetCard();
                    MessageBox.Show("Không có sách");
                }
            }
            else
            {
                ResetCard();
            }
        }
        private void ReduceBook(Stock stock)
        {// giảm số lượng sách

            lsbBorrowBook.Items.Add(stock);
            foreach (var item in Stocks)
            {
                if (string.Compare(stock.Id, item.Id) == 0)
                {
                    item.Quantity--;
                }
            }
            lsbCurrentBook.Items.Clear();
            foreach (var item in Stocks)
            {
                if (item.Quantity != 0)
                {
                    lsbCurrentBook.Items.Add(item);
                }
            }
            if (stock.Quantity == 0)
                lsbCurrentBook.Items.Remove(stock);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (CheckExistence.ReaderStatus(txtIdReader.Text) == true)
            {
                if (count >= Regulation.Quantity)
                {
                    MessageBox.Show(string.Format("You can only borrow " + Regulation.Quantity + " books at most"));
                    return;
                }
                else
                {
                    var item = (sender as Button).DataContext as Stock;
                    ReduceBook(item);
                    StocksTemp.Add(item);
                    count++;
                }
            }
            else
            {
                if (txtIdReader.Text == "")
                    MessageBox.Show("Reader id not entered");
                else
                    MessageBox.Show("Account has been locked");
            }
        }
        private void IncreaseBook(Stock stock)
        {
            lsbBorrowBook.Items.Remove(stock);
            foreach (var item in Stocks)
            {
                if (string.Compare(stock.Id, item.Id) == 0)
                {
                    item.Quantity++;
                }
            }
            lsbCurrentBook.Items.Clear();
            foreach (var item in Stocks)
            {
                if (item.Quantity != 0)
                {
                    lsbCurrentBook.Items.Add(item);
                }
            }
            if (stock.Quantity == 1)
            {
                lsbCurrentBook.Items.Add(stock);
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var item = (sender as Button).DataContext as Stock;
            IncreaseBook(item);
            StocksTemp.Remove(item);
            count--;
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (StocksTemp.Count != 0)
            {
                if (MessageBox.Show("Are you creat new Call Card?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes) {
                    CallCard callCard = new CallCard(new GetNewId().GetNewIdCallCard(), txtIdReader.Text, DateTime.Now, DateTime.Now.AddDays(Regulation.DayReturn), count, null);
                    var write1 = new CallCardXMLWrite();
                    write1.WriteCallCard(callCard, StocksTemp);
                    var write2 = new StockXMLWrite();
                    write2.UpdateStock(StocksTemp);
                    Stocks = new StockViewModel().GetStocks();
                    CallCards = CallCardVM.GetCallCards(txtIdReader.Text);
                    ResetBiding();
                    ResetCard();
                    StocksTemp.Clear();
                    MessageBox.Show("Create a Call Card successfully");
                }
            }
            else {
                MessageBox.Show("You have not selected the book");
            }
        }
    }
}
