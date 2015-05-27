namespace UniversalInsurance.RatingEngine
{
    public class RatingCalculator
    {
        public decimal GetRating(Vehicle vehicle)
        {
            var carRating = vehicle.Manufacturer == Manufacturer.Audi ? 1.5m * 800m : 2.0m * 800m;
            var vanRating = vehicle.Manufacturer == Manufacturer.Audi ? 1.5m * 1000m : 2.0m * 1000m;
            return vehicle.Class == VehicleClass.Car ? carRating : vanRating;
        }
    }
}
