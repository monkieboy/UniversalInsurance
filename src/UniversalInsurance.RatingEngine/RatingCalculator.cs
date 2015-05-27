namespace UniversalInsurance.RatingEngine
{
    public class RatingCalculator
    {
        public decimal GetRating(Vehicle vehicle)
        {
            var carRating = 800m;
            var vanRating = 2000m;

            return vehicle.Class == VehicleClass.Car ? carRating : vanRating;
        }
    }
}
