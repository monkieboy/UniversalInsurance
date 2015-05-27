namespace UniversalInsurance.RatingEngine
{
    public interface IRatingCalculator
    {
        decimal CalculatePremium(Vehicle vehicle);
    }
}