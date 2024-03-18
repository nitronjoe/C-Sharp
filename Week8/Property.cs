using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week8
{
    class Property
    {
        // auto-implemented properties
        public string Address { get; set; }
        public int Value { get; set; }
        public int ID { get; set; }

        public int ShortGUID()
        {
            byte[] buffer = Guid.NewGuid().ToByteArray();
            uint FormNumber = BitConverter.ToUInt32(buffer, 0) 
                ^ BitConverter.ToUInt32(buffer, 4) 
                ^ BitConverter.ToUInt32(buffer, 8) 
                ^ BitConverter.ToUInt32(buffer, 12);

            return (int) FormNumber;
        }
    }
}
