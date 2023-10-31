using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class CallCardViewModel
    {
        public List<ViewCallCard> GetViewCallCards(ObservableCollection<CallCard> callCards) {
            if (callCards == null)
                return null;
            else {
                List<ViewCallCard> viewCallCards = new List<ViewCallCard>();
                foreach (var item in callCards)
                {
                    foreach (var item1 in item.Books)
                    {
                        viewCallCards.Add(new ViewCallCard(item.Id, item.IdReader, item.BorrowDate, item.ReturnDate, item1.Status, item1));
                    }
                }
                return viewCallCards;
            }
        }
        public ObservableCollection<CallCard> GetCallCards(string Idreader)
        {
            ObservableCollection<CallCard> callCards = new ObservableCollection<CallCard>();
            string fileName = @"Data/CallCards.xml";
            XmlNodeList lstNode = DataProvider.getDsNode(string.Format("/CallCards/CallCard[@IdReader='{0}']", Idreader), fileName);
            if (lstNode.Count == 0)
                return null;
            XmlNodeList lstNode1;
            List<Book> books;
            CallCard callCard;
            foreach (XmlNode node in lstNode)
            {
                if (string.Compare(node.Attributes["Status"].Value, "1") == 0)
                {
                    callCard = new CallCard();
                    lstNode1 = DataProvider.getDsNode(string.Format("/CallCards/CallCard[@Id='{0}']/Book", node.Attributes["Id"].Value), fileName);
                    books = new List<Book>();
                    foreach (XmlNode node1 in lstNode1)
                    {
                        if (string.Compare(node1.Attributes["Status"].Value, "1") == 0)
                        {
                            books.Add(new Book(node1.Attributes["Id"].Value, node1.Attributes["Name"].Value,int.Parse(node.Attributes["Status"].Value)));
                        }
                    }
                    callCard.Id = node.Attributes["Id"].Value;
                    callCard.IdReader = node.Attributes["IdReader"].Value;
                    callCard.BorrowDate = DateTime.Parse(node.Attributes["BorrowDate"].Value);
                    callCard.ReturnDate = DateTime.Parse(node.Attributes["ReturnDate"].Value);
                    callCard.Quantity = int.Parse(node.Attributes["Quantity"].Value);
                    callCard.Books = books;
                    callCards.Add(callCard);
                }
            }
            return callCards;
        }
    }
}
