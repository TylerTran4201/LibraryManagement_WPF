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
    /// Interaction logic for frmReaderAdd.xaml
    /// </summary>
    public partial class frmReaderAdd : Window
    {
        public frmReaderAdd()
        {
            InitializeComponent();
            txtId.Text = new GetNewId().GetNewIdReader();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (txtId.Text == "" || txtFirstName.Text == "" || txtLastname.Text == "" || txtCMND.Text == "" || cbSex.SelectedIndex == -1 || dtDob.Text == "")
            {
                MessageBox.Show("Cannot be left blank");
            }
            else {
              
                if (MessageBox.Show("Are you sure to add new reader?", "Question", MessageBoxButton.YesNo, MessageBoxImage.Warning) == MessageBoxResult.Yes)
                {
                    Reader reader = new Reader(txtId.Text, new Name(txtFirstName.Text, txtLastname.Text), txtCMND.Text, DateTime.Parse(dtDob.Text), (cbSex.SelectedIndex == 0) ? "male" : "female", txtEmail.Text);
                    var write = new ReaderXMLWrite();
                    write.AddReader(reader);
                    this.Close();
                }
            }
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
