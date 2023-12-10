using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rentals
{
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Enums.Rental;
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rentals.PaymentManagement;
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Services;

    internal class Rental
    {
        private readonly decimal _id;
        private readonly decimal _vehicleId;
        private readonly decimal _customerId;
        private readonly DateTime startDate;
        private DateTime endDate;
        private double cost;
        private double initialMileage;
        private double finalMileage;
        private VehicleCondition vehicleCondition;
        private Payment payment;

        public decimal Id { get { return _id; } private set { } }
        public decimal VehicleId { get { return _vehicleId; } private set { } }
        public decimal CustomerId { get { return _customerId; } private set { } }

        public Rental(decimal id, decimal vehicleId, decimal customerId,
            DateTime startDate, double initialMileage, double finalMileage, Payment payment)
        {
            this._id = id;
            this._vehicleId = vehicleId;
            this._customerId = customerId;
            this.startDate = startDate;
            this.initialMileage = initialMileage;
            this.finalMileage = finalMileage;
            this.payment = payment;
        }

        public double EndRental(VehicleCondition vehicleCondition)
        {
            this.vehicleCondition = vehicleCondition;
            endDate = DateTime.Today;

            CalculateCost();

            return cost;
        }

        private void CalculateCost()
        {
            TimeSpan difference = endDate - startDate;

            int howManyDaysTheRentalLasted = (int)Math.Ceiling(difference.TotalDays);

            cost = InventoryService.GetVehiclePricePerDayById(VehicleId) * howManyDaysTheRentalLasted;
        }
    }
}
