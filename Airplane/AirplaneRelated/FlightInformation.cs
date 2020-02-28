using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airplane
{
    public static class FlightInformation
    {
        private static List<Airplane> flightInfo = new List<Airplane>();
        private static List<Airplane> customPlanes = new List<Airplane>();

        public static void AddInformation(Airplane a)
        {
            flightInfo.Add(a);
        }
        public static void AddCustomPlane(Airplane a)
        {
            customPlanes.Add(a);
        }
        public static void RemoveAirplane(int id)
        {
            foreach(Airplane item in flightInfo)
            {
                if(id == item.ID)
                {
                    flightInfo.Remove(item);
                    break;
                }
            }
        }
        public static List<Airplane>GetInformation()
        {
            List<Airplane> test = new List<Airplane>();
            foreach(Airplane item in flightInfo)
            {
                test.Add(item);
            }
            return test;
        }
        public static List<Airplane> GetCustomPlanes()
        {
            List<Airplane> test = new List<Airplane>();
            foreach (Airplane item in customPlanes)
            {
                test.Add(item);
            }
            return test;
        }
        public static Airplane GetPlane(string type)
        {
            foreach (Airplane item in GetAllPlanes())
            {
                if (item.Type == type)
                {
                    return item;
                }
            }
            return null;
        }
        public static Airplane GetAirplaneInfo(int id)
        {
            foreach(Airplane item in GetAllPlanes())
            {
                if(item.ID == id)
                {
                    return item;
                }
            }
            return null;
        }
        public static List<Airplane> GetAllPlanes()
        {
            List<Airplane> test = new List<Airplane>();
            foreach (Airplane item in flightInfo)
            {
                test.Add(item);
            }
            foreach (Airplane item in customPlanes)
            {
                test.Add(item);
            }

            return test;
        }
        
            public static List<Pilot>GetAllPilots(Airplane a)
        {
            List<Pilot> pilots = new List<Pilot>();
            foreach(Person item in a.GetAllPeople())
            {
                if(item is Pilot)
                {
                    pilots.Add((Pilot)item);
                }
            }
            return pilots;
        }
        public static List<Attendant> GetAllAttendants(Airplane a)
        {
            List<Attendant> attendants = new List<Attendant>();
            foreach (Person item in a.GetAllPeople())
            {
                if (item is Attendant)
                {
                    attendants.Add((Attendant)item);
                }
            }
            return attendants;
        }
    }
}
