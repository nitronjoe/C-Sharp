using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    class Enums
    {
        public enum Ptype
        {
            Detached,
            SemiDetached,
            Terrace,
            Bungalow,
            Unknown
        }

        public enum TType
        {
            Freehold,
            LeaseHold,
            Unknown
        }

        public enum IType
        {
            Factory,
            Warehouse,
            Office,
            Unknown
        }
    }
}
