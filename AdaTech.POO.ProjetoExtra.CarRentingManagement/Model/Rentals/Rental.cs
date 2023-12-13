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
        private readonly DateTime _startDate;
        private DateTime _endDate;
        private double _cost;
        private double _initialMileage;
        private double _finalMileage;
        private VehicleCondition _vehicleCondition;
        private Payment _payment;

        public decimal Id { get { return _id; } private set { } }
        public decimal VehicleId { get { return _vehicleId; } private set { } }
        public decimal CustomerId { get { return _customerId; } private set { } }

        public DateTime StartDate { get { return _startDate; } private set { } }
        public DateTime EndDate { get { return _endDate; } private set { } }

        public Rental(decimal id, decimal vehicleId, decimal customerId,
            DateTime startDate, double initialMileage, double finalMileage, Payment payment)
        {
            this._id = id;
            this._vehicleId = vehicleId;
            this._customerId = customerId;
            this._startDate = startDate;
            this._initialMileage = initialMileage;
            this._finalMileage = finalMileage;
            this._payment = payment;
        }

        public Rental(decimal id, decimal vehicleId, decimal customerId,
            DateTime startDate, DateTime endDate, double initialMileage, double finalMileage, Payment payment)
        {
            this._id = id;
            this._vehicleId = vehicleId;
            this._customerId = customerId;
            this._startDate = startDate;
            this._endDate = endDate;
            this._initialMileage = initialMileage;
            this._finalMileage = finalMileage;
            this._payment = payment;
        }

        public double EndRental(VehicleCondition vehicleCondition)
        {
            this._vehicleCondition = vehicleCondition;
            _endDate = DateTime.Today;

            CalculateCost();

            return _cost;
        }

        private void CalculateCost()
        {
            TimeSpan difference = _endDate - _startDate;

            int howManyDaysTheRentalLasted = (int)Math.Ceiling(difference.TotalDays);

            _cost = InventoryService.GetVehiclePricePerDayById(VehicleId) * howManyDaysTheRentalLasted;
        }
    }
}
