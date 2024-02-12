using CMP1903MWorkshopCode;
using System;


//Week 3
//Task 1: create Message object, call the readTextFromInput() method
//Task 2: create Atbash object Step 1: pass message to encode() method Step 2: put in the encode logic
//Task 3: put in the decode logic to the decode() method, check if it works
//Task 4: read text to encode from a file


namespace CMP1903M_Workshops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new method object.
            Message m = new Message();
            // Call the method to get text from the console.
            m.readMessageFromInput();
            Console.WriteLine($"The message to be encoded is the following: {m.message}");


            // Create a new Atbash object.
            Atbash atbash = new Atbash();
            // Perform error handling for empty strings/null input.
            string inputMessage = m.message;
            if (string.IsNullOrEmpty( inputMessage ) )
            {
                Console.WriteLine("Error: Input string is empty or null");
            }
            else
            {
                string text = atbash.encode(m.message);
                // Return the encoded message and print it out to the console.
                Console.WriteLine($"The encoded message is: {text}");
                // Pass the encoded message for decoding.
                string decodedText = atbash.decode(text);
                // Return the decoded message and print it out to the console.
                Console.WriteLine($"The decoded message is: {decodedText}");
            }

            // Task 4
            //string filename = "MyFile.txt"; // Create txt file in the same directory. // Make sure file name here matches with file.
            //Message m1 = new Message();
            // m1.readMessageFromFile(filename);
            //Console.WriteLine($"The message of the file is: {m1.message}");


            Console.ReadKey();
            
        }
    }
}
