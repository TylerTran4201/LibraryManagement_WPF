using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class ReaderXMLWrite
    {
        public void UnlockReader(Reader reader) {
            string fileName = @"Data/Readers.xml";
            XmlNode node = DataProvider.getNode(string.Format("/Readers/Reader[@Id='{0}']", reader.Id), fileName);
            node.Attributes["Status"].Value = "1";
            DataProvider.Close(fileName);
        }
        public void LockReader(Reader reader) {
            string fileName = @"Data/Readers.xml";
            XmlNode node = DataProvider.getNode(string.Format("/Readers/Reader[@Id='{0}']", reader.Id), fileName);
            node.Attributes["Status"].Value = "0";
            DataProvider.Close(fileName);
        }
        public void UpdateReader(Reader reader)
        {
            string fileName = @"Data/Readers.xml";
            XmlNode node = DataProvider.getNode(string.Format("/Readers/Reader[@Id='{0}']", reader.Id), fileName);
            node.Attributes["Id"].Value = reader.Id;
            node.Attributes["FirstName"].Value = reader.Name.FirstName;
            node.Attributes["LastName"].Value = reader.Name.LastName;
            node.Attributes["CMND"].Value = reader.CMND;
            node.Attributes["Dob"].Value = reader.Dob.ToString("MM/dd/yyyy");
            node.Attributes["Sex"].Value = reader.Sex;
            node.Attributes["Email"].Value = reader.Email;
            DataProvider.Close(fileName);
        }
        public void AddReader(Reader reader)
        {
            string fileName = @"Data/Readers.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode root = doc.SelectSingleNode("/Readers");
            XmlNode node = doc.CreateElement("Reader", null);
            XmlAttribute att;
            att = doc.CreateAttribute("Id");
            att.Value = reader.Id;
            node.Attributes.Append(att);


            att = doc.CreateAttribute("FirstName");
            att.Value = reader.Name.FirstName;
            node.Attributes.Append(att);

            att = doc.CreateAttribute("LastName");
            att.Value = reader.Name.LastName;
            node.Attributes.Append(att);

            att = doc.CreateAttribute("CMND");
            att.Value = reader.CMND;
            node.Attributes.Append(att);

            att = doc.CreateAttribute("Dob");
            att.Value = reader.Dob.ToString("MM/dd/yyyy");
            node.Attributes.Append(att);

            att = doc.CreateAttribute("Sex");
            att.Value = reader.Sex;
            node.Attributes.Append(att);

            att = doc.CreateAttribute("Email");
            att.Value = reader.Email;
            node.Attributes.Append(att);

            att = doc.CreateAttribute("Status");
            att.Value = "1";
            node.Attributes.Append(att);

            root.AppendChild(node);
            doc.Save(fileName);
        }
    }
}
