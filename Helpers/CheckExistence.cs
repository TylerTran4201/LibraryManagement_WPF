using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class CheckExistence
    {
        public static bool IdReader(string id)
        {
            string fileName = @"Data/Readers.xml";
            XmlNode node = DataProvider.getNode(string.Format("/Readers/Reader[@Id='{0}']", id), fileName);
            if (node == null)
                return false;
            return true;
        }
        public static bool ReaderStatus(string id)
        {
            string fileName = @"Data/Readers.xml";
            XmlNode node = DataProvider.getNode(string.Format("/Readers/Reader[@Id='{0}']", id), fileName);
            if (node == null)
                return false;
            else if (string.Compare(node.Attributes["Status"].Value, "0") == 0)
                return false;
            return true;
        }
    }
}
