using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    public class Airplane
    {
        private int id;
        private static int seeder = 1000;
        private string type;
        private int amountOfEconomySeats;
        private int amountOfBusinessSeats;
        private bool inUse;

        private List<Seat> seatsEconomy;
        private List<Seat> seatsBusiness;
        private List<Person> peopleEconomy;
        private List<Person> peopleBusiness;
        private List<Person> peopleEmployees;
    
        public string Type { get { return this.type; } }
        public int ID { get { return id; } set { id = value; } }
        public bool InUse { get { return this.inUse; } set { this.inUse = value; } }
        public string Name { get { return $"{this.type} - {id}"; } }
        public int AmountOfEconomySeats { get { return this.amountOfEconomySeats; } }
        public int AmountOfBusinessSeats { get { return this.amountOfBusinessSeats; } }
        public int AmountOfTotalSeats { get { return this.AmountOfBusinessSeats + this.AmountOfEconomySeats; } }
        public Airplane(string type, int amountOfSeats, int amountOfBusinessSeats)
        {
            ID = seeder;
            this.type = type;
            this.amountOfEconomySeats = amountOfSeats;
            this.amountOfBusinessSeats = amountOfBusinessSeats;
            seatsEconomy = new List<Seat>(this.amountOfEconomySeats);
            seatsBusiness = new List<Seat>(this.amountOfBusinessSeats);
            peopleEconomy = new List<Person>();
            peopleBusiness = new List<Person>();
            peopleEmployees = new List<Person>();
            InUse = false;
            seeder++;
        }
        public Airplane(int amountOfSeats, int amountOfBusinessSeats, string type)
        {
            this.type = type;
            this.amountOfEconomySeats = amountOfSeats;
            this.amountOfBusinessSeats = amountOfBusinessSeats;
            InUse = false;
        }
        public bool CommenceFlight()
        {
            if (peopleEconomy.Count > 0 && peopleBusiness.Count > 0)
            {
                InUse = true;
                return true;
            }
            return false;
        }
        public void RemovePerson(string name)
        {
            foreach (Person p in peopleEconomy)
            {
               if(p.Name == name)
                {
                    peopleEconomy.Remove(p);
                    break;
                }
            }
            foreach (Person p in peopleBusiness)
            {
                if (p.Name == name)
                {
                    peopleBusiness.Remove(p);
                    break;
                }
            }
            foreach (Person p in peopleEmployees)
            {
                if (p.Name == name)
                {
                    peopleEmployees.Remove(p);
                    break;
                }
            }
        }
        public void AddEconomySeat(Seat s)
        {
            seatsEconomy.Add(s);
        }
        public void AddBusinessSeat(Seat s)
        {
            seatsBusiness.Add(s);
        }
        public List<Seat> GetAllEconomySeats()
        {
            List<Seat> test = new List<Seat>();
            foreach (Seat s in seatsEconomy)
            {
                test.Add(s);
            }

            return test;
        }
        public List<Seat> GetAllBusinessSeats()
        {
            List<Seat> test = new List<Seat>();
            foreach (Seat s in seatsBusiness)
            {
                test.Add(s);
            }
            return test;
        }
        public void AddPerson(Person p)
        {
            peopleEconomy.Add(p);
        }
        public void AddPersonBusiness(Person p)
        {
            peopleBusiness.Add(p);
        }
        public void AddPersonEmployee(Person p)
        {
            peopleEmployees.Add(p);
        }

        public List<Person> GetAllPeople()
        {
            List<Person> test = new List<Person>();
            foreach (Person p in peopleEconomy)
            {
                test.Add(p);
            }
            foreach (Person p in peopleBusiness)
            {
                test.Add(p);
            }
            foreach (Person p in peopleEmployees)
            {
                test.Add(p);
            }
            return test;
        }
        public List<Person> GetAllBusinessPeople()
        {
            List<Person> test = new List<Person>();
            foreach (Person p in peopleBusiness)
            {
                test.Add(p);
            }
            return test;
        }
        public List<Person> GetAllEconomyPeople()
        {
            List<Person> test = new List<Person>();
            foreach (Person p in peopleEconomy)
            {
                test.Add(p);
            }
            return test;
        }

        public Person GetPerson(string name)
            {
            foreach (Person p in GetAllPeople())
            {
                if(p.Name == name)
                {
                    return p;
                }
            }
            return null;
            }

        public void AssignSeatsEconomy()
        {
            Random randomness = new Random();
            List<int> listNumbers = new List<int>();
            int assign;
            foreach (Person person in peopleEconomy)
            {
                do
                {
                    assign = randomness.Next(0, peopleEconomy.Count);
                    
                }
                while (listNumbers.Contains(assign));

                listNumbers.Add(assign);
                seatsEconomy[assign].AddPassenger(person);

            }

        }
        public void AssignSeatsBusiness()
        {
            Random randomness = new Random();
            List<int> listNumbers = new List<int>();
            int assign;
            foreach (Person person in peopleBusiness)
            {
                do
                {
                    assign = randomness.Next(0, peopleBusiness.Count);
                   
                }
                while (listNumbers.Contains(assign));

                listNumbers.Add(assign);
                seatsBusiness[assign].AddPassenger(person);

            }
        }
        public string GetInfoCreated()
        {
            return $"Aircraft - {this.type} has {this.AmountOfTotalSeats} seats - ID:{id}";
        }
        public string GetInfoInUse()
        {
            return $"Aircraft - {this.type} has {this.AmountOfTotalSeats} seats and it is carrying {peopleBusiness.Count + peopleEconomy.Count} passangers - ID:{id}";
        }
    }
}
