using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class GetNewId
    {
        public string GetNewIdReader()
        {
            StringBuilder IdReader = new StringBuilder();
            string fileName = @"Data/Readers.xml";
            XmlNode root = DataProvider.getNode("/Readers", fileName);
            XmlNode node = root.LastChild;
            string str = node.Attributes["Id"].Value.Remove(0, 1);
            int temp = int.Parse(str) + 1;
            if (temp.ToString().Length == 1)
                IdReader.Append(string.Format(node.Attributes["Id"].Value.Substring(0, 1) + "0" + temp.ToString()));
            else
                IdReader.Append(string.Format(node.Attributes["Id"].Value.Substring(0, 1) + temp.ToString()));
            return IdReader.ToString();
        }
        public string GetNewIdCallCard()
        {
            StringBuilder idReport = new StringBuilder();
            string fileName = @"Data/CallCards.xml";
            XmlNode root = DataProvider.getNode("/CallCards", fileName);
            XmlNode node = root.LastChild;
            if (node == null)
            {
                return "RP01";
            }
            string str = node.Attributes["Id"].Value.Remove(0, 2);
            int temp = int.Parse(str) + 1;
            if (temp.ToString().Length == 1)
                idReport.Append(string.Format(node.Attributes["Id"].Value.Substring(0, 2) + "0" + temp.ToString()));
            else
                idReport.Append(string.Format(node.Attributes["Id"].Value.Substring(0, 2) + temp.ToString()));
            return idReport.ToString();
        }
    }
}
