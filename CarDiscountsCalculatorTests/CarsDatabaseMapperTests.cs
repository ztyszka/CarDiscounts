using NUnit.Framework;
using CarDiscountsCalculator;
using CarDiscountsDatabase;
using System.Collections.Generic;

namespace CarDiscountsCalculatorTests
{

    class CarsDatabaseMapperTests
    {
        CarsDatabaseMapper mapper;
        [SetUp]
        public void Setup()
        {
            List<CarDiscountsDatabase.IDatabaseCar> cars = new List<CarDiscountsDatabase.IDatabaseCar>();
            cars.Add(new CarDiscountsDatabase.DatabaseCar("Toyota", "Auris", 25000));
            mapper = new CarsDatabaseMapper(cars);
        }

        [Test]
        public void CarsDatabaseCreatedCorrectly()
        {
            Dictionary<int, BusinessCar> carsDatabase = new Dictionary<int, BusinessCar>();
            carsDatabase.Add(0, new BusinessCar(0, "Toyota", "Auris", 25000, 0));
            Assert.AreEqual(carsDatabase, mapper.CarsDatabase);
            // test się wywala, bo porównuję wskaźniki na struktury, a nie ich wartości
        }
    }
}
