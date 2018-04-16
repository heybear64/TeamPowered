using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamPowered
{
    class Program
    {
        static void Main(string[] args)
        {
            var teams = LoadTeams();
            var people = LoadPeople();

        }


        private static List<Team> LoadTeams()
        {
            List<Team> teams = new List<Team>() { new Team("Red"), new Team("Blue") };
            return teams;
        }

        private static List<Person> LoadPeople()
        {
            List<Person> persons = new List<Person>() { new Person("Joe", "Smith"), new Person("John", "Doe") };
            return persons;

        }
    }
}
