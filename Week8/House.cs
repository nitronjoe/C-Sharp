using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    class House : Property
    {
        public Enums.Ptype propertyType { get; set; }
        public int numberOfBedrooms { get; set; }
        public bool garage { get; set; }

        // House constructor
        // ID, 
        public House(string a, int v, int n, bool g, int PropType)
        {
            Address = a;
            Value = v;
            numberOfBedrooms = n;
            garage = g;

        }
    }
}
