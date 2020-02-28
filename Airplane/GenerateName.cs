using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
     public class GenerateName
    {
        private List<string> FirstNames = new List<string>();
        private List<string> LastNames = new List<string>();

        public void GenerateNames()
        {
            //First Names
            FirstNames.Add("John");
            FirstNames.Add("Spade");
            FirstNames.Add("Dave");
            FirstNames.Add("Seth");
            FirstNames.Add("Ivan");
            FirstNames.Add("Riley");
            FirstNames.Add("Gilbert");
            FirstNames.Add("Jorge");
            FirstNames.Add("Dan");
            FirstNames.Add("Brian");
            FirstNames.Add("Roberto");
            FirstNames.Add("Ramon");
            FirstNames.Add("Miles");
            FirstNames.Add("Liam");
            FirstNames.Add("Nathaniel");
            FirstNames.Add("Ethan");
            FirstNames.Add("Lewis");
            FirstNames.Add("Milton");
            FirstNames.Add("Claude");
            FirstNames.Add("Joshua");
            FirstNames.Add("Glen");
            FirstNames.Add("Harvey");
            FirstNames.Add("Blake");
            FirstNames.Add("Antonio");
            FirstNames.Add("Connor");
            FirstNames.Add("Julian");
            FirstNames.Add("Aidan");
            FirstNames.Add("Harold");
            FirstNames.Add("Conner");
            FirstNames.Add("Peter");
            FirstNames.Add("Hunter");
            FirstNames.Add("Eli");
            FirstNames.Add("Alberto");
            FirstNames.Add("Carlos");
            FirstNames.Add("Shane");
            FirstNames.Add("Aaron");
            FirstNames.Add("Marlin");
            FirstNames.Add("Paul");
            FirstNames.Add("Ricardo");
            FirstNames.Add("Hector");
            FirstNames.Add("Alexis");
            FirstNames.Add("Adrian");
            FirstNames.Add("Kingston");
            FirstNames.Add("Douglas");
            FirstNames.Add("Gerald");
            FirstNames.Add("Joey");
            FirstNames.Add("Johnny");
            FirstNames.Add("Charlie");
            FirstNames.Add("Scott");
            FirstNames.Add("Martin");
            FirstNames.Add("Tristin");

            //Last Names
            LastNames.Add("Crawford");
            LastNames.Add("Mason");
            LastNames.Add("Rice");
            LastNames.Add("Black");
            LastNames.Add("Knight");
            LastNames.Add("Arnold");
            LastNames.Add("Wagner");
            LastNames.Add("Mosby");
            LastNames.Add("Ramirez");
            LastNames.Add("Coleman");
            LastNames.Add("Powell");
            LastNames.Add("Singh");
            LastNames.Add("Patel");
            LastNames.Add("Wood");
            LastNames.Add("Wright");
            LastNames.Add("Stephens");
            LastNames.Add("Eriksen");
            LastNames.Add("Cook");
            LastNames.Add("Roberts");
            LastNames.Add("Holmes");
            LastNames.Add("Kennedy");
            LastNames.Add("Saunders");
            LastNames.Add("Fisher");
            LastNames.Add("Hunter");
            LastNames.Add("Reid");
            LastNames.Add("Stewart");
            LastNames.Add("Carter");
            LastNames.Add("Phillips");
            LastNames.Add("Spencer");
            LastNames.Add("Howell");
            LastNames.Add("Alvarezv");
            LastNames.Add("Little");
            LastNames.Add("Jacobs");
            LastNames.Add("Foreman");
            LastNames.Add("Knowles");
            LastNames.Add("Meadows");
            LastNames.Add("Richmond");
            LastNames.Add("Valentine");
            LastNames.Add("Dudley");
            LastNames.Add("Woodward");
            LastNames.Add("Weasley");
            LastNames.Add("Livingston");
            LastNames.Add("Sheppard");
            LastNames.Add("Kimmel");
            LastNames.Add("Noble");
            LastNames.Add("Leach");
            LastNames.Add("Gentry");
            LastNames.Add("Lara");
            LastNames.Add("Pace");
            LastNames.Add("Trujillo");
            LastNames.Add("Grant");
        }
        public List<string> FirstName()
        {
            List<string> storage = new List<string>();
            foreach(string name in FirstNames)
            {
                storage.Add(name);
            }
            return storage;
        }
        public List<string> LastName()
        {
            List<string> storage = new List<string>();
            foreach (string name in LastNames)
            {
                storage.Add(name);
            }
            return storage;
        }

    }
}
