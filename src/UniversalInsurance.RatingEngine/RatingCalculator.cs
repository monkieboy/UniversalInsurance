namespace UniversalInsurance.RatingEngine
{
    public class RatingCalculator
    {
        public decimal CalculatePremium(Vehicle vehicle)
        {
            return vehicle.Manufacturer.Factor * vehicle.Type.BasePremium;
        }
    }
}
