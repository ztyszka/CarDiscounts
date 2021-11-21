using System;
using System.Collections.Generic;
using CarDiscountsDatabase;
using System.Linq;

namespace CarDiscountsCalculator
{
    
    class Program
    {
        static void PrintCars(Dictionary<int, BusinessCar> cars)
        {
            Console.WriteLine("[Car id] -- Car brand -- Car model -- price before discount -- discount percentage -- price after discount");
            Console.WriteLine();
            foreach ((_, BusinessCar car) in cars)
                Console.WriteLine("[{0}] -- {1} -- {2} -- {3} -- {4} -- {5}", car.CarID, car.CarBrand, car.CarModel, car.CarPrice, car.DiscountPercentage, car.CarPrice * ((100 - car.DiscountPercentage) / 100));
            // zabrakło mi czasu na formatowanie
        }

        static Dictionary<int, BusinessCar> FilterByMaxPriceAfterDiscount(Dictionary<int, BusinessCar> cars, double filterCondition)
        {
            var filteredCars = from car in cars
                                       where (car.Value.CarPrice * ((100 - car.Value.DiscountPercentage) / 100) <= filterCondition)
            select car;
            Dictionary<int, BusinessCar> result = new Dictionary<int, BusinessCar>();
            foreach (var car in filteredCars)
                result.Add(car.Key, car.Value);
            return result;
        }

        static void Main(string[] args)
        {
            List<IDatabaseCar> database = Database.FillEcampleOfDatabase();
            ICarsDatabaseMapper carsDatabaseMapper = new CarsDatabaseMapper(database);
            PrintCars(carsDatabaseMapper.CarsDatabase);
            
            Console.WriteLine("You can filter results by price after discount.");
            Console.WriteLine("Please, enter maximum price you are interested in:");
            string tmpPrice = Console.ReadLine();
            double price = int.MaxValue;
            if (double.TryParse(tmpPrice, out price) == false)
                Console.WriteLine("You entered incorrect value.");
            // umożliwić ponowne podanie danych

            Dictionary<int, BusinessCar> filteredCars = FilterByMaxPriceAfterDiscount(carsDatabaseMapper.CarsDatabase, price);
            Console.WriteLine("Filtered results:");
            PrintCars(filteredCars);

        }
    }
}
