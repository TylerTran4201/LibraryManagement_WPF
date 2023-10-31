using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class ReaderViewModel
    {
        public ObservableCollection<Reader> GetReaders()
        {
            ObservableCollection<Reader> readers = new ObservableCollection<Reader>();
            string fileName = @"Data/Readers.xml";
            XmlNodeList lstNode = DataProvider.getDsNode("/Readers/Reader", fileName);
            Reader reader = new Reader();
            foreach (XmlNode node in lstNode)
            {
                reader = new Reader();
                reader.Id = node.Attributes["Id"].Value;
                reader.Name = new Name(node.Attributes["FirstName"].Value, node.Attributes["LastName"].Value);
                string temp = node.Attributes["Dob"].Value;
                reader.Dob = DateTime.Parse(node.Attributes["Dob"].Value);
                reader.Email = node.Attributes["Email"].Value;
                reader.CMND = node.Attributes["CMND"].Value;
                reader.Sex = node.Attributes["Sex"].Value;
                reader.Status = int.Parse(node.Attributes["Status"].Value);
                readers.Add(reader);
            }
            return readers;
        }
    }
}
