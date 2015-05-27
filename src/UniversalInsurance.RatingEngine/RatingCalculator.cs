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
            switch (vehicle.Manufacturer)
            {
                case Manufacturer.Audi:
                    return vehicle.Factor * BasePremium(vehicle.Class);
                case Manufacturer.Mercedes:
                    return vehicle.Factor * BasePremium(vehicle.Class);
                default:
                    return 0;
            }
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
