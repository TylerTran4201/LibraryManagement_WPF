using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace WPF_LibraryManagement
{
    class RegulationViewModel
    {
        public Regulation GetRegulation()
        {
            string fileName = @"Data/Regulation.xml";
            XmlNode node = DataProvider.getNode("/Regulation", fileName);
            Regulation regulation = new Regulation();
            regulation.DayReturn = int.Parse(node.Attributes["DayReturn"].Value);
            regulation.Quantity = int.Parse(node.Attributes["Quantity"].Value);
            return regulation;
        }
    }
}
