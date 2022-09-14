using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DefiningClasses
{
    public class Family
    {
        public List<Person> ListOfPeople { get; set; } = new List<Person>();

        public void AddPerson(Person person)
        {
            ListOfPeople.Add(person);
        }
        public Person GetOldestMember()
        {
            List<Person> sortedList = ListOfPeople.OrderByDescending(person => person.Age).ToList();

            return sortedList[0];

        }

    }
}
