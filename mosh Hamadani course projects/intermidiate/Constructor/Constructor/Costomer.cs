using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Constructor
{
    public class Costomer
    {
        public int Id;
        public string Name;
        public List<Order> Orders;

        public Costomer()
        {
            Orders = new List<Order>();
        }
        public Costomer(int id)
        {
            this.Id = id;
        }
        public Costomer(int id , string name)
            : this(id)
        {
            
            this.Name = name;

        }
    }
}
