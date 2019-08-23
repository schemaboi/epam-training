namespace Epam.HomeWork.Training_3
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public sealed class PeopleList : IEnumerable<Person>, ICloneable
    {
        private readonly List<Person> peopleList;

        #region Constructors

        public PeopleList() : this(0)
        { }

        public PeopleList(int size) : this(new List<Person>(size))
        { }

        public PeopleList(IEnumerable<Person> collection)
        {
            peopleList = new List<Person>(collection);
        }

        #endregion

        #region Properties

        public int Count => peopleList.Count;

        public Person this[int i]
        {
            get => peopleList[i];

            set => peopleList[i] = value;
        }

        #endregion

        #region Interfaces

        public IEnumerator<Person> GetEnumerator()
        {
            return ((IEnumerable<Person>)peopleList).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Person>)peopleList).GetEnumerator();
        }

        public object Clone()
        {
            return new PeopleList(peopleList);
        }

        #endregion

        #region Methods

        public void AddPerson(Person person)
        {
            peopleList.Add(person);
        }

        public void AddPeopleRange(IEnumerable<Person> range)
        {
            peopleList.AddRange(range);
        }

        public bool RemovePerson(Person person)
        {
            return peopleList.Remove(person);
        }

        public void RemovePersonAt(int index)
        {
            peopleList.RemoveAt(index);
        }
         
        public int RemoveAllPeople(Predicate<Person> predicate)
        {
            return peopleList.RemoveAll(predicate);
        }

        public void Clear()
        {
            peopleList.Clear();
        }

        public void PrintAll()
        {
            foreach(var person in peopleList)
            {
                Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
            }
        }

        public void PrintAllWithPhoneNumbers()
        {
            foreach (var person in peopleList)
            {
                Console.WriteLine(person);
            }
        }

        #endregion
    }
}
