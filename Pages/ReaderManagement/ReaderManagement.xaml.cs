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
    /// Interaction logic for ReaderManagement.xaml
    /// </summary>
    public partial class ReaderManagement : UserControl
    {
        ObservableCollection<Reader> Readers { get; set; }
        ReaderViewModel ReaderVM = new ReaderViewModel();
        private Reader SelectedReader = new Reader();
        public ReaderManagement()
        {
            InitializeComponent();
            Readers = ReaderVM.GetReaders();
            foreach (var item in Readers)
            {
                lsbReaderCards.Items.Add(item);
            }
        }
        private void ResetCard()
        {
            lsbReaderCards.Items.Clear();
            foreach (var item in Readers)
            {
                lsbReaderCards.Items.Add(item);
            }
        }
        private Reader GetReaderAtTxt()
        {
            Reader reader = new Reader();
            reader.Id = SelectedReader.Id;
            reader.Name = SelectedReader.Name;
            reader.CMND = txtCMND.Text;
            reader.Dob = DateTime.Parse(txtDob.Text);
            reader.Sex = (cbSex.SelectedIndex == 0) ? "male" : "female";
            reader.Email = txtEmail.Text;
            return reader;
        }
        private void SetValueTextBox(Reader reader)
        {
            if (reader != null)
            {
                txtId.Text = reader.Id;
                txtName.Text = reader.Name.FullName;
                txtCMND.Text = reader.CMND;
                txtDob.Text = reader.Dob.ToString("MM/dd/yyyy");
                cbSex.SelectedIndex = (string.Compare(reader.Sex, "male") == 0) ? 0 : 1;
                txtEmail.Text = reader.Email;
                return;
            }
            txtId.Text = "";
            txtName.Text = "";
            txtCMND.Text = "";
            txtDob.Text = "";
            cbSex.SelectedIndex = -1;
            txtEmail.Text = "";

        }
        private void BtnCard_Click(object sender, RoutedEventArgs e)
        {
            var item = (sender as Button).DataContext as Reader;
            SetValueTextBox(item);
            SelectedReader = item;
        }

        private int CountInput = 0;
        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cbTypeSearch.SelectedIndex == -1)
                return;
            Readers = new ReaderViewModel().GetReaders();
            ObservableCollection<Reader> temp = Readers;
            CountInput++;
            if (Readers.Count == 0 || txtSearch.Text == "" || txtSearch.Text.Length < CountInput)
            {
                CountInput--;
                Readers = temp;

                ResetCard();

                if (txtSearch.Text == "")
                    return;
            }
            temp = new ObservableCollection<Reader>();
            // 1.Id or 2.Name
            switch (cbTypeSearch.SelectedIndex)
            {
                case 0:
                    {
                        foreach (var item in Readers)
                        {
                            if (item.Id.Contains(txtSearch.Text))
                                temp.Add(item);
                        }
                        break;
                    }
                case 1:
                    {
                        foreach (var item in Readers)
                        {
                            if (item.Name.FullName.Contains(txtSearch.Text))
                                temp.Add(item);
                        }
                        break;
                    }
            }
            Readers = temp;
            ResetCard();
        }
        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text != "")
            {
                if (MessageBox.Show("Are you sure to Edit this reader?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    var write = new ReaderXMLWrite();
                    var reader = GetReaderAtTxt();
                    write.UpdateReader(reader);
                    Readers = ReaderVM.GetReaders();
                    ResetCard();
                    SetValueTextBox(null);
                }
                else {
                    return;
                }
               
            }
            else {
                MessageBox.Show("have not selected readers yet");
            }
        }
        private void BtnLock_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text != "")
            {
                var item = SelectedReader;
                if (item.Status == 1)
                {
                    var screen = new frmReaderLockReason();
                    screen.Handler += delegate (ref Reader reader)
                    {
                        reader = item;
                    };
                    screen.ShowDialog();
                    Readers = ReaderVM.GetReaders();
                    ResetCard();
                    SetValueTextBox(null);
                }
                else
                {
                    MessageBox.Show("This Reader already locked");
                }
            }
            else {
                MessageBox.Show("have not selected readers yet");
            }
        }

        private void BtnUnlock_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text != "")
            {
                if (MessageBox.Show("Are you sure to unlock this reader?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    var write = new ReaderLockReasonXMLWrite();
                    write.RemoveReason(SelectedReader);
                    var write1 = new ReaderXMLWrite();
                    write1.UnlockReader(SelectedReader);

                    Readers = ReaderVM.GetReaders();
                    ResetCard();
                    SetValueTextBox(null);
                }
                else
                {
                    return;
                }
            }
            else {
                MessageBox.Show("have not selected readers yet");
            }
        }
        private void AddNewBook_Click(object sender, RoutedEventArgs e)
        {
            SetValueTextBox(null);
            var screen = new frmReaderAdd();
            screen.ShowDialog();
            Readers = ReaderVM.GetReaders();
            ResetCard();
        }
    }
}
