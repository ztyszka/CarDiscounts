using System;
using System.Collections.Generic;
using System.Text;

namespace CarDiscountsDatabase
{
    public class Car : ICar
    {
        private int carID;
        private string carBrand;
        private string carModel;
        private double carPrice;

        public Car(int carID, string carBrand, string carModel, double carPrice)
        {
            this.carID = carID;
            this.carBrand = carBrand;
            this.carModel = carModel;
            this.carPrice = carPrice;
        }

        public int CarID { get { return carID; } }
        public string CarBrand { get { return carBrand; } }
        public string CarModel { get { return carModel; } }
        public double CarPrice
        {
            get { return carPrice; }
            set { carPrice = value; }
        }
    }
}
