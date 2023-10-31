using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_LibraryManagement
{
    class Stock
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public int Quantity { get; set; }
        public Stock(string id, string name, string category, int quantity)
        {
            this.Id = id;
            this.Name = name;
            this.Quantity = quantity;
            this.Category = category;
        }
        public Stock(string id, int quantity)
        {
            this.Id = id;
            this.Quantity = quantity;
        }
        public Stock()
        {

        }
    }
}
