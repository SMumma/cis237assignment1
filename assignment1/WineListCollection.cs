using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineListCollection
    {
        private int id;
        private string name;
        private decimal cost;

        public WineListCollection(string id, string name, int cost)
        {
            this.Id = int.Parse(id);
            this.Name = name;
            this.Cost = cost;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }
    }
}
