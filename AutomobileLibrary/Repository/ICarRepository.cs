using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using AutomobileLibrary.DataAccess;
namespace AutomobileLibrary.Repository
{
    public interface ICarRepository
    {
        IEnumerable<car> GetCars();
        Car GetCarByID(int carId);
        void InsertCar(Car car);
        void DeleteCar(int carId);
        void UpdateCar(Car car);
    }
}