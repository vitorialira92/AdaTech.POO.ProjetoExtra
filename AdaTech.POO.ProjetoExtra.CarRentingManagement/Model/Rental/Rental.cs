using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rental
{
    using AdaTech.POO.ProjetoExtra.CarRentingManagement.Model.Rental.PaymentManagement;
    internal class Rental
    {
        private readonly decimal id;
        private readonly decimal VehicleId;
        private readonly decimal vehicleId;
        private readonly DateTime startDate;
        private DateTime endDate;
        private double cost;
        private double initialMileage;
        private double finalMileage;
        private VehicleCondition vehicleCondition;
        private Payment payment;

        public Rental(decimal id, decimal VehicleId, decimal vehicleId,
            DateTime startDate, double initialMileage, double finalMileage, Payment payment)
        {
            this.id = id;
            this.VehicleId = VehicleId;
            this.vehicleId = vehicleId;
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

            cost = Inventory.GetVehiclePricePerDayById(vehicleId) * howManyDaysTheRentalLasted;
        }
    }
}
