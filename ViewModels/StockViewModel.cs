using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class StockViewModel
    {
        private void GetDetailStocks(ref List<Stock> stocks)// get Book's name, category 
        {
            ObservableCollection<Category> categories = new CategoryViewModel().GetCategories();
            foreach (var item in stocks)
            {
                foreach (var item1 in categories) {
                    if (string.Compare(item1.Id, "ALL") != 0)
                        continue;
                    foreach (var item2 in item1.Books)
                    {
                        if (string.Compare(item.Id, item2.Id) == 0)
                        {
                            item.Category = item2.Category;
                            item.Name = item2.Name;
                        }
                    }
                }
            }
        }
        public List<Stock> GetStocks()
        {
            List<Stock> stocks = new List<Stock>();
            string fileName = @"Data/Stock.xml";
            XmlNodeList lstNode = DataProvider.getDsNode("/Books/Book", fileName);
            foreach (XmlNode node in lstNode)
            {
                if (string.Compare(node.Attributes["Quantity"].Value, "0") == 1)
                {
                    stocks.Add(new Stock(node.Attributes["Id"].Value, int.Parse(node.Attributes["Quantity"].Value)));
                }
            }
            GetDetailStocks(ref stocks);
            return stocks;
        }
    }
}
