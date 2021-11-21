using System;
using System.Collections.Generic;
using System.Text;
using CarDiscountsDatabase;

namespace CarDiscountsCalculator
{
    public interface ICarsDatabaseMapper
    {
        BusinessCar SearchCar(int carId);
        List<BusinessCar> SearchBrand(string brand);
        List<BusinessCar> SearchModel(string model);
        bool AddCar(BusinessCar car);
        bool DeleteCar(BusinessCar car);
    }
}
