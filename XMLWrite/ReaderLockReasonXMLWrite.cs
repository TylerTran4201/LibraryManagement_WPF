using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class ReaderLockReasonXMLWrite
    {
        public void WriteReason(Reader reader, string reason)
        {
            string fileName = @"Data/ReadersLockReason.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode root = doc.SelectSingleNode("/Readers");
            XmlNode node = doc.CreateElement("Reader", null);
            XmlAttribute att;
            att = doc.CreateAttribute("IdReader");
            att.Value = reader.Id;
            node.Attributes.Append(att);

            att = doc.CreateAttribute("Reason");
            att.Value = reason;
            node.Attributes.Append(att);

            att = doc.CreateAttribute("Date");
            att.Value = DateTime.Now.ToString("MM/dd/yyyy");
            node.Attributes.Append(att);
            root.AppendChild(node);
            doc.Save(fileName);
        }
        public void RemoveReason(Reader reader)
        {
            string fileName = @"Data/ReadersLockReason.xml";
            XmlDocument doc = new XmlDocument();
            doc.Load(fileName);
            XmlNode node = doc.SelectSingleNode(string.Format("/Readers/Reader[@IdReader='{0}']", reader.Id));
            if (node != null)
            {
                XmlNode parent = node.ParentNode;
                parent.RemoveChild(node);
                doc.Save(fileName);
                return;
            }
        }
    }
}
