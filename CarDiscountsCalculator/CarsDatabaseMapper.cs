using System;
using System.Collections.Generic;
using CarDiscountsDatabase;

namespace CarDiscountsCalculator
{
    public class CarsDatabaseMapper : ICarsDatabaseMapper
    {
        private Dictionary<int, BusinessCar> carsDatabase;
        public CarsDatabaseMapper(IEnumerable<BusinessCar> cars)
        {
            carsDatabase = new Dictionary<int, BusinessCar>();
            foreach (BusinessCar car in cars)
                carsDatabase.Add(car.CarID, car);
        }
        public bool AddCar(BusinessCar car)
        {
            if (carsDatabase.ContainsKey(car.CarID))
                return false;   // warto dodać raportowanie błędów
            carsDatabase.Add(car.CarID, car);
            return true;
        }

        public bool DeleteCar(BusinessCar car)
        {
            if (!carsDatabase.ContainsKey(car.CarID))
                return false;   // warto dodać raportowanie błędów
            carsDatabase.Remove(car.CarID);
            return true;
        }

        public List<BusinessCar> SearchBrand(string brand)
        {
            List<BusinessCar> cars = new List<BusinessCar>();
            foreach (BusinessCar car in cars)
                if (car.CarBrand == brand)
                    cars.Add(car);
            return cars;
        }

        public BusinessCar SearchCar(int carId)
        {     
            return carsDatabase.ContainsKey(carId) ? carsDatabase[carId] : null;
        }

        public List<BusinessCar> SearchModel(string model)
        {
            List<BusinessCar> cars = new List<BusinessCar>();
            foreach (BusinessCar car in cars)
                if (car.CarModel == model)
                    cars.Add(car);
            return cars;
        }
    }
}
