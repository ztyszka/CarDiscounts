using System;
using System.Collections.Generic;
using System.Text;

namespace CarDiscountsDatabase
{
    public interface IDatabaseCar
    {
        public string CarBrand { get; }
        public string CarModel { get; }
        public double CarPrice { get; set; }

    }
}
