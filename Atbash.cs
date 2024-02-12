using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903MWorkshopCode
{
    class Atbash
    {
        public string encode(string text)
        {
            // Initialise a string to store the encoded message.
            string reversedText = "";
            // Encode the message by reversing the order of the letters inputted.
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            return reversedText;
        }

        public string decode(string text)
        {
            // Initialise a string to store the encoded message.
            string reversedText = "";
            // Decode the message by reversing the order of the letters inputted.
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reversedText += text[i];
            }
            return reversedText;
        }
    }
}