using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5
{
    internal class Person
    {
        // Class Fields
        private string _firstName;
        private string _lastName;
        private string _email;
        private string _screenName;
        private int _id;

        private static HashSet<int> _useIDs = new HashSet<int>();

        // Properties
        public string FirstName { get { return _firstName; } set { _firstName = value; } }
        public string LastName { get { return _lastName; } set { _lastName = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public string ScreenName { get { return _screenName; } set { _screenName = value; } }
        public int ID { get { return _id; } set { _id = value; } }

        // Default Constructor
        public Person()
            : this("DefaultFirstName", "DefaultLastName", "EmailNotSet") { }

        public Person(string firstName, string lastName)
            : this(firstName, lastName, "EmailNotSet")
        {
            GenerateScreenName();
        }

        private void GenerateScreenName()
        {
            Random random = new Random();
            int randomNumber = random.Next(0, 10000);
            _screenName = $"{_firstName.ToLower()[0]}{_lastName.ToLower()}{randomNumber:D4}";
        }

        public Person(string firstName, string lastName, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }
        // Method to output person information as a string.
        public string Output()
        {
            return $"Name: {_firstName} {_lastName} E-mail: {_email}";
        }

        public override string ToString()
        {
            return $"Name: {_firstName} {_lastName} E-mail: {_email} Screen Name: {_screenName}";
        }
        private void GenerateUniqueID()
        {
            Random random = new Random();
            int randomNumber;
            do
            {
                randomNumber = random.Next(0, 10000);
            } while (_useIDs.Contains(randomNumber));
            _id = randomNumber;
            _useIDs.Add(randomNumber);
        }

    }
}
