using Lab1A.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1A.Data
{
    public class DealershipMgr
    {
        public static Dealership dealership1 = new Dealership { Email = "test1@mohwakcollege.ca", Id = 1, Name = "John", PhoneNumber = "2345672211" };
        public static Dealership dealership2 = new Dealership { Email = "test2@mohwakcollege.ca", Id = 2, Name = "Peter", PhoneNumber = "1345672211" };
        public static Dealership dealership3 = new Dealership { Email = "test3@mohwakcollege.ca", Id = 3, Name = "Erin", PhoneNumber = "6345672211" };

        private static List<Dealership> dealerships = new List<Dealership>();


        public void Add()
        {
            dealerships.Add(dealership1);
            dealerships.Add(dealership2);
            dealerships.Add(dealership3);
        }

        public IEnumerable<Dealership> GetDearlership()
        {
            return dealerships;
        }

        public Dealership GetDearlership(int id)
        {
            return dealerships[id];
        }

        public void PostDearlership(Dealership dealership)
        {
            dealerships.Add(dealership);
        }

        public void PutDearlership(int id, Dealership dealership)
        {
            dealerships[id] = dealership;
        }
        public void DeleteDealership(int id)
        {
            dealerships.Remove(dealerships[id]);
        }


    }
}
