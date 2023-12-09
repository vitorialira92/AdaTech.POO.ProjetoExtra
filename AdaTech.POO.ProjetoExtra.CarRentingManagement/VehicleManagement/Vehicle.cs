using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.VehicleManagement
{
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.VehicleManagement.Enums;
    internal class Vehicle
    {
        public decimal Id { get { return Id; } private set { Id = value; } }
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
            Id = id;
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
    }
}
