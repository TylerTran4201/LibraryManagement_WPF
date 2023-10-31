using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class StockXMLWrite
    {
        public void ReturnBook(Book book)
        {
            string fileName = @"Data/Stock.xml";
            XmlNode node = DataProvider.getNode(string.Format("/Books/Book[@Id='{0}']", book.Id), fileName);
            node.Attributes["Quantity"].Value = (int.Parse(node.Attributes["Quantity"].Value) + 1).ToString();
            DataProvider.Close(fileName);
        }
        public void UpdateStock(List<Stock> stocks)
        {
            string fileName = @"Data/Stock.xml";
            XmlNode node;
            foreach (var item in stocks)
            {
                node = DataProvider.getNode(string.Format("/Books/Book[@Id='{0}']", item.Id), fileName);
                node.Attributes["Quantity"].Value = (int.Parse(node.Attributes["Quantity"].Value) - 1).ToString();
                DataProvider.Close(fileName);
            }
        }
    }
}
