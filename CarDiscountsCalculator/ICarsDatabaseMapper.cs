using System;
using System.Collections.Generic;
using System.Text;
using CarDiscountsDatabase;

namespace CarDiscounts
{
    public interface ICarsDatabaseMapper
    {
        ICar SearchCar(int carId);
        List<ICar> SearchBrand(string brand);
        List<ICar> SearchModel(string model);
        bool AddCar(ICar car);
        bool DeleteCar(ICar car);
    }
}
