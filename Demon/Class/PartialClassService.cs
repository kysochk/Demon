using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demon
{
    partial class Service
    {
        public decimal newcost { get; set; }
        public string Decor;
        public string decor
        {
            get { return Decor; }
            set { Decor = value; }
        }
        public string Green;
        public string green
        {
            get { return Green; }
            set { Green = value; }
        }
    }
}
