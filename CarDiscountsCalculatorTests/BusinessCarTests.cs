using NUnit.Framework;
using CarDiscountsCalculator;

namespace CarDiscountsCalculatorTests
{
    public class BusinessCarTests
    {

        BusinessCar car;
        [SetUp]
        public void Setup()
        {
            car = new BusinessCar(3, "Saab", "93", 25000, 10);
        }

        [Test]
        public void CarIdTestIsEqual()
        {
            Assert.AreEqual(3, car.CarID);
        }

        [Test]
        public void CarBrandIsEqual()
        {
            Assert.AreEqual("Saab", car.CarBrand);
        }

        [Test]
        public void CarBrandIsNotEqual()
        {
            Assert.AreNotEqual("Toyota", car.CarBrand);
        }
        [Test]
        public void CarDiscountSetToAcceptableValue()
        {
            car.DiscountPercentage = 50;
            Assert.AreEqual(50, car.DiscountPercentage);
        }
        public void CarDiscountSetToGreaterThan100()
        {
            car.DiscountPercentage = 120;
            Assert.AreNotEqual(120, car.DiscountPercentage);
        }
    }
}