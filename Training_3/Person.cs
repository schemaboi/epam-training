namespace Epam.HomeWork.Training_3
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Text;

    public class Person : IEquatable<Person>, ICloneable
    {
        public Person() : this("", 0, new List<ContactNumber>())
        { }

        public Person(string name, int age, List<ContactNumber> phoneNumbers)
        {
            Name = name;
            Age = age;
            PhoneNumbers = new List<ContactNumber>(phoneNumbers);
        }

        #region Interfaces

        public object Clone()
        {
            return new Person(Name, Age, new List<ContactNumber>(PhoneNumbers));
        }

        public bool Equals(Person other) 
        {
            return Name == other.Name
                && Age == other.Age
                && PhoneNumbers.SequenceEqual(other.PhoneNumbers);
        }

        #endregion

        #region Properties

        public string Name { get; set; } = "";

        public int Age { get; set; }

        public List<ContactNumber> PhoneNumbers { get; set; }

        #endregion

        #region Operators

        public static bool operator ==(Person left, Person right)
            => left.Equals(right);

        public static bool operator !=(Person left, Person right)
            => !left.Equals(right);

        #endregion

        #region Methods

        public override bool Equals(object obj)
        {
            return obj is Person person && Equals(person); 
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            const int IndentSize = 4;

            var stringBuilder = new StringBuilder();
            stringBuilder.Append($"{Name}, Age: {Age}, Phone Numbers:\n");

            foreach(var contact in PhoneNumbers)
            {
                stringBuilder.Append(new string(' ', IndentSize) + contact.ToString() + '\n');
            }

            return stringBuilder.ToString();
        }

        #endregion
    }
}
