using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class CallCardXMLWrite
    {
        public void ReturnBook(string idCallCard, Book book)
        {
            string fileName = @"Data/CallCards.xml";
            int temp;
            XmlNodeList lstNode = DataProvider.getDsNode(string.Format("/CallCards/CallCard[@Id='{0}']/Book", idCallCard), fileName);
            foreach (XmlNode node1 in lstNode)
            {
                if (string.Compare(node1.Attributes["Id"].Value, book.Id) == 0)
                {
                    if (string.Compare(node1.Attributes["Status"].Value, "1") == 0)
                    {
                        node1.Attributes["Status"].Value = "0";
                        DataProvider.Close(fileName);
                        break;
                    }
                }
            }
            XmlNode node;
            node = DataProvider.getNode(string.Format("/CallCards/CallCard[@Id='{0}']", idCallCard), fileName);
            temp = int.Parse(node.Attributes["Quantity"].Value) - 1;
            node.Attributes["Quantity"].Value = temp.ToString();
            if (temp == 0)
                node.Attributes["Status"].Value = "0";
            DataProvider.Close(fileName);

        }
        public void WriteCallCard(CallCard callCard, List<Stock> stocks)
        {
            string fileName = @"Data/CallCards.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode root1 = doc.SelectSingleNode("/CallCards");
            XmlNode node1 = doc.CreateElement("CallCard", null);
            XmlAttribute att;

            att = doc.CreateAttribute("Id");
            att.Value = callCard.Id;
            node1.Attributes.Append(att);

            att = doc.CreateAttribute("IdReader");
            att.Value = callCard.IdReader;
            node1.Attributes.Append(att);

            att = doc.CreateAttribute("BorrowDate");
            att.Value = callCard.BorrowDate.ToString("MM/dd/yyyy");
            node1.Attributes.Append(att);

            att = doc.CreateAttribute("ReturnDate");
            att.Value = callCard.ReturnDate.ToString("MM/dd/yyyy");
            node1.Attributes.Append(att);

            att = doc.CreateAttribute("Quantity");
            att.Value = callCard.Quantity.ToString();
            node1.Attributes.Append(att);

            att = doc.CreateAttribute("Status");
            att.Value = "1";
            node1.Attributes.Append(att);

            root1.AppendChild(node1);

            doc.Save(fileName);


            foreach (var item in stocks)
            {
                doc = new XmlDocument();
                doc.Load(fileName);
                XmlNode root2 = doc.SelectSingleNode(string.Format("/CallCards/CallCard[@Id='{0}']", callCard.Id));
                XmlNode node2 = doc.CreateElement("Book", null);

                att = doc.CreateAttribute("Id");
                att.Value = item.Id;
                node2.Attributes.Append(att);

                att = doc.CreateAttribute("Name");
                att.Value = item.Name;
                node2.Attributes.Append(att);

                att = doc.CreateAttribute("Status");
                att.Value = "1";
                node2.Attributes.Append(att);

                root2.AppendChild(node2);
                doc.Save(fileName);
            }

        }
    }
}
