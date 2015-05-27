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
            return vehicle.Manufacturer.Factor * vehicle.Type.BasePremium;
        }
    }
}
