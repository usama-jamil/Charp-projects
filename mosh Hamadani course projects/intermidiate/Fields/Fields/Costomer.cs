using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Fields
{
    class Costomer
    {
        public int Id;
        public string Name;
        public readonly List<Order> Order = new List<Order>();

        public Costomer(int id)
        {
            this.Id = id;
        }
        public Costomer(int id , string name)
            :this(id)
        {
            this.Name = name;
        }
        public void Promote()
        {
           // Order = new List<Order>();               this is read only error
        }
    }
}
