namespace UniversalInsurance.RatingEngine
{
    public interface IVehicleType
    {
        decimal BasePremium { get; }
    }

    public class Van : IVehicleType
    {
        public Van(decimal basePremium)
        {
            BasePremium = basePremium;
        }

        public decimal BasePremium { get; private set; }
    }

    public class Car : IVehicleType
    {
        public decimal BasePremium { get; private set; }

        public Car(decimal basePremium)
        {
            BasePremium = basePremium;
        }
    }
}