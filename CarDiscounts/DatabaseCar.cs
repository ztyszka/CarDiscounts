using System;
using System.Collections.Generic;
using System.Text;

namespace CarDiscountsDatabase
{
    public class DatabaseCar : IDatabaseCar
    {
        private string carBrand;
        private string carModel;
        private double carPrice;

        public DatabaseCar(string carBrand, string carModel, double carPrice)
        {
            this.carBrand = carBrand;
            this.carModel = carModel;
            this.carPrice = carPrice;
        }

        public string CarBrand { get { return carBrand; } }
        public string CarModel { get { return carModel; } }
        public double CarPrice
        {
            get { return carPrice; }
            set { carPrice = value; }
        }
    }
}
