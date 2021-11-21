using System;
using System.Collections.Generic;
using System.Text;
using CarDiscountsDatabase;

namespace CarDiscountsCalculator
{
    public interface ICarsDatabaseMapper
    {
        Dictionary<int, BusinessCar> CarsDatabase { get; }
        BusinessCar SearchCar(int carId);
        List<BusinessCar> SearchBrand(string brand);
        List<BusinessCar> SearchModel(string model);
        bool AddCar(BusinessCar car);
        bool DeleteCar(BusinessCar car);
        void UpdateDiscounts(BusinessCar car);
    }
}
