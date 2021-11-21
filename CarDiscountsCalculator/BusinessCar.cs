using System;
using System.Collections.Generic;
using System.Text;

namespace CarDiscountsCalculator
{
    public class BusinessCar
    {
        private int carID;
        private string carBrand;
        private string carModel;
        private double carPrice;
        private double discountPercentage = 0;

        public BusinessCar(int id, string carBrand, string carModel, double carPrice, double discountPercentage = 0)
        {
            this.carID = id;                // należałoby zadbać o unikalność id
            this.carBrand = carBrand;
            this.carModel = carModel;
            this.carPrice = carPrice;
            if (discountPercentage <= 100)  // nie może być więcej niż 100% zniżki
                this.discountPercentage = discountPercentage;
        }
        public int CarID { get { return carID; } }
        public string CarBrand { get { return carBrand; } }
        public string CarModel { get { return carModel; } }
        public double CarPrice
        {
            get { return carPrice; }
            set { carPrice = value; }
        }
        public double DiscountPercentage
        {
            get { return discountPercentage; }
            set { if(value <= 100) discountPercentage = value; }
        }
    }
}
