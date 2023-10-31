using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class DataProvider
    {
        static XmlDocument doc = null;
        static XmlNode nodeRoot = null;

        public static void Open(string pathData)
        {
            if (doc == null)
                doc = new XmlDocument();
            doc.Load(pathData);
            nodeRoot = doc.DocumentElement;
        }

        public static void Close(string pathData)
        {
            if (doc != null)
                doc.Save(pathData);
        }

        public static XmlNodeList getDsNode(string xpath, string pathData)
        {
            doc = null;
            if (doc == null)
                Open(pathData);
            return nodeRoot.SelectNodes(xpath);

        }

        public static XmlNode getNode(string xpath, string pathData)
        {

            Open(pathData);
            return nodeRoot.SelectSingleNode(xpath);
        }

        public static XmlNode createNode(string tagName, string pathData)
        {
            XmlNode node = doc.CreateElement(tagName);
            return node;
        }

        public static XmlAttribute createAttr(string name, string pathData)
        {
            XmlAttribute attr = doc.CreateAttribute(name);
            return attr;
        }

        public static XmlNode getNode(string xpath, int index, string pathData)
        {
            XmlNode temp = doc.SelectSingleNode(xpath);
            for (int i = 0; i < index; i++)
            {
                temp = temp.NextSibling;
            }
            return temp;
        }

        // Thêm 1 nút con tại vị trí cuối trong nút gốc (nút cha)
        public static void AppendNode(XmlNode node, XmlNode newNode, string pathData)
        {
            node.AppendChild(newNode);
            Close(pathData);
        }
    }
}
