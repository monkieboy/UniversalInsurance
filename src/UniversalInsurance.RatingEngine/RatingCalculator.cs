namespace UniversalInsurance.RatingEngine
{
    public class RatingCalculator
    {
        public decimal GetPremium(Vehicle vehicle)
        {
            return CalculatePremium(vehicle);
        }

        private static decimal CalculatePremium(Vehicle vehicle)
        {
            var premium = ApplyRatings(vehicle);

            return premium;
        }

        private static decimal ApplyRatings(Vehicle vehicle)
        {
            return vehicle.Manufacturer.Factor * BasePremium(vehicle.Class);
        }

        private static decimal BasePremium(VehicleClass vehicleClass)
        {
            return vehicleClass == VehicleClass.Car ? CarBasePremium : VanBasePremium;
        }

        private static decimal VanBasePremium
        {
            get { return 1000m; }
        }

        private static decimal CarBasePremium
        {
            get { return 800m; }
        }
    }
}
