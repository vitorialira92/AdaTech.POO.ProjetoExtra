using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.VehicleManagement.model
{
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.Vehicle;

    internal class Vehicle
    {
        private decimal _id;
        public decimal Id { get { return _id; } private set { _id = value; } }
        private CarBrand brand;
        private string model;
        private int year;
        private int seats;
        private string color;
        private CarType type;
        private CarStatus status;
        private double mileage;
        private double pricePerDay;
        public double PricePerDay { get { return pricePerDay; } private set { } }

        public Vehicle(decimal id, CarBrand brand, string model, int year, int seats, string color,
                CarType type, double mileage, double pricePerDay)
        {
            _id = id;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.seats = seats;
            this.color = color;
            this.type = type;
            this.mileage = mileage;
            this.pricePerDay = pricePerDay;
            status = CarStatus.Available;
        }

        public Vehicle(decimal id, CarBrand brand, string model, int year, int seats, string color,
                CarType type, CarStatus status, double mileage, double pricePerDay)
        {
            _id = id;
            this.brand = brand;
            this.model = model;
            this.year = year;
            this.seats = seats;
            this.color = color;
            this.type = type;
            this.status = status;
            this.mileage = mileage;
            this.pricePerDay = pricePerDay;

        }

        public void UpdatePrice(double newPrice)
        {
            pricePerDay = newPrice;
        }

        public void UpdateStatus(CarStatus newStatus)
        {
            status = newStatus;
        }

        public void IncreaseMileage(double additionalMileage)
        {
            mileage += additionalMileage;
        }

        public override string ToString()
        {
            return $"{brand} {model} {year} | {color}\n{type} : {seats} seats\nPrice per day: ${pricePerDay} | {status}";
        }

        public CarStatus GetCarStatus() { return this.status; }
    }
}
