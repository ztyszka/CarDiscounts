using System;
using System.Collections.Generic;
using CarDiscountsDatabase;

namespace CarDiscountsCalculator
{
    public class CarsDatabaseMapper : ICarsDatabaseMapper
    {
        private int nextId;
        private Dictionary<int, BusinessCar> carsDatabase;
        public CarsDatabaseMapper(List<IDatabaseCar> cars)
        {
            nextId = 0;
            carsDatabase = new Dictionary<int, BusinessCar>();
            foreach (DatabaseCar car in cars)
            {
                carsDatabase.Add(nextId, new BusinessCar(nextId, car.CarBrand, car.CarModel, car.CarPrice));
                UpdateDiscounts(carsDatabase[nextId]);
                nextId++;
            }
                
        }

        public Dictionary<int, BusinessCar> CarsDatabase { get { return carsDatabase; } }

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

        public void UpdateDiscounts(BusinessCar car)
        {
            car.DiscountPercentage = car.CarID % 100;
        }
    }
}
