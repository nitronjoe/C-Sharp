using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlTypes;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    class Shop : Property
    {
        public Enums.Ptype propertyType { get; set; }
        public Enums.TType tenureType { get; set; }
        public float squareMetres { get; set; }
    }

    public Shop (int id, string a, int v, int n, bool g, int tenType)
    {
        ID = id;
        Address = a;
        Value = v;
        squareMetres = SqM;


        // Set property type.
        switch (tenType)
        {
            case 1: tenureType = Enums.TType.LeaseHold; break;
            case 2: tenureType = Enums.TType.Freehold; break;
            case 3: tenureType = Enums.TType.Unknown; break;
        }

        // Set property type.
        switch (propType)
        {
            case 1: propertyType = Enums.Ptype.SemiDetached; break;
            case 2: propertyType = Enums.Ptype.SemiDetached; break;
            case 3: propertyType = Enums.Ptype.SemiDetached; break;
            case 4: propertyType = Enums.Ptype.SemiDetached; break;
            default: propertyType = Enums.Ptype // ?
        }
    }
}
