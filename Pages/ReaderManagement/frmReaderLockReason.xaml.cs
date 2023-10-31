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
    /// Interaction logic for frmReaderLockReason.xaml
    /// </summary>
    public partial class frmReaderLockReason : Window
    {
        public delegate void MyDelegate(ref Reader ReaderReceive);
        public event MyDelegate Handler;
        public Reader reader { get; set; }
        public frmReaderLockReason()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if (Handler != null)
            {
                Reader readerTemp = new Reader();
                Handler(ref readerTemp);
                reader = readerTemp;
                this.DataContext = reader;
            }
        }
        private void BtnLock_Click(object sender, RoutedEventArgs e)
        {
            string lockReason = (txtReason.Text == "") ? "No Reason" : txtReason.Text;
            if (MessageBox.Show("Are you sure lock this reader?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
            {
                var write = new ReaderXMLWrite();
                write.LockReader(reader);
                var write1 = new ReaderLockReasonXMLWrite();
                write1.WriteReason(reader,lockReason);
                this.Close();
            }
            else
            {
                return;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

     
    }
}
