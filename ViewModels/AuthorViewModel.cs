using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class AuthorViewModel
    {
        public ObservableCollection<Author> GetAuthors()
        {
            ObservableCollection<Author> Authors = new ObservableCollection<Author>();
            string fileName = @"Data/Authors.xml";
            XmlNodeList lstNode = DataProvider.getDsNode("/Authors/Author", fileName);
            foreach (XmlNode node in lstNode)
            {
                Authors.Add(new Author(node.Attributes["Id"].Value, node.Attributes["Name"].Value));
            }
            return Authors;
        }
    }
}
