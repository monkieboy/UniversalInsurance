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
            var premium = ApplyRatings(vehicle.Manufacturer, vehicle.Class);
            
            return premium;
        }

        private static decimal ApplyRatings(Manufacturer manufacturer, VehicleClass vehicleClass)
        {
            switch (manufacturer)
            {
                case Manufacturer.Audi:
                    return AudiFactor * BasePremium(vehicleClass);
                case Manufacturer.Mercedes:
                    return MercedesFactor * BasePremium(vehicleClass);
                default:
                    return 0;
            }
        }

        private static decimal MercedesFactor
        {
            get { return 2.0m; }
        }

        private static decimal AudiFactor
        {
            get { return 1.5m; }
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
