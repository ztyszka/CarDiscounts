using System;
using System.Collections.Generic;
using System.Text;

namespace CarDiscountsDatabase
{
    public class Database
    {
        public List<IDatabaseCar> FillEcampleOfDatabase()
        {
            List<IDatabaseCar> cars = new List<IDatabaseCar>();
            cars.Add(new DatabaseCar("Toyota", "Auris", 45000));
            cars.Add(new DatabaseCar("Toyota", "Corolla", 60000));
            cars.Add(new DatabaseCar("Saab", "93", 20000));
            cars.Add(new DatabaseCar("Saab", "95", 25000));
            cars.Add(new DatabaseCar("Citroen", "C3", 5000));
            cars.Add(new DatabaseCar("Toyota", "Corolla", 80000));

            return cars;
        }
    }
}
