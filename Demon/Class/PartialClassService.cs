﻿using System;
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
        public string Visible;
        public string visible
        {
            get { return Visible; }
            set { Visible = value; }
        }


        public string VisibleD;
        public string visibleD
        {
            get { return VisibleD; }
            set { VisibleD = value; }
        }
        public string VisBtn;
        public string visiblebtn
        {
            get { return VisBtn; }
            set { VisBtn = value; }
        }
    }
}
