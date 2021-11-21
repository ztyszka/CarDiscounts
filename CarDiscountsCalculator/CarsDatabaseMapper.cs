using System;
using System.Collections.Generic;
using CarDiscountsDatabase;

namespace CarDiscounts
{
    public class CarsDatabaseMapper : ICarsDatabaseMapper
    {
        private Dictionary<int, ICar> carsDatabase;
        public CarsDatabaseMapper(IEnumerable<ICar> cars)
        {
            carsDatabase = new Dictionary<int, ICar>();
            foreach (ICar car in cars)
                carsDatabase.Add(car.CarID, car);
        }
        public bool AddCar(ICar car)
        {
            if (carsDatabase.ContainsKey(car.CarID))
                return false;   // warto dodać raportowanie błędów
            carsDatabase.Add(car.CarID, car);
            return true;
        }

        public bool DeleteCar(ICar car)
        {
            if (!carsDatabase.ContainsKey(car.CarID))
                return false;   // warto dodać raportowanie błędów
            carsDatabase.Remove(car.CarID);
            return true;
        }

        public List<ICar> SearchBrand(string brand)
        {
            List<ICar> cars = new List<ICar>();
            foreach (ICar car in cars)
                if (car.CarBrand == brand)
                    cars.Add(car);
            return cars;
        }

        public ICar SearchCar(int carId)
        {     
            return carsDatabase.ContainsKey(carId) ? carsDatabase[carId] : null;
        }

        public List<ICar> SearchModel(string model)
        {
            List<ICar> cars = new List<ICar>();
            foreach (ICar car in cars)
                if (car.CarModel == model)
                    cars.Add(car);
            return cars;
        }
    }
}
