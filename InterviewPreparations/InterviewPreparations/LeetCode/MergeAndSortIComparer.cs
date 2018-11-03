using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions.LeetCode
{
    class MergeAndSortIComparer
    {
        public static List<Person> MergeandSortIComparer()
        {
            var dictionary = new Dictionary<string, int>();

            dictionary.Add("Prakash", 35);
            dictionary.Add("Amit", 32);
            dictionary.Add("Gaurav", 34);
            dictionary.Add("Ajay", 40);

            List<Person> lstPerson = new List<Person>();

            foreach(var item in dictionary.Keys)
            {
                lstPerson.Add(new Person(item, dictionary[item]));
            }

            lstPerson.Sort(new MergeComparer());

            foreach (var item in lstPerson)
            {
                Console.WriteLine(item.Name + " - " + item.Age);
            }

            return null;
        }
    }

    public class MergeComparer : IComparer<Person>
    {
        public int Compare(Person p2, Person p1)
        {
            if (p1.Age > p2.Age)
            {
                return 1;
            }
            else if (p1.Age == p2.Age)
            {
                return 0;
            }
            else
            {
                return -1;
            }
        }
    }


    public class Person
    {
        public string Name;
        public int Age;

        public Person(string name, int Age)
        {
            this.Name = name;
            this.Age = Age;
        }
    }
}

