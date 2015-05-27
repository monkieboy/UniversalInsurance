namespace UniversalInsurance.RatingEngine
{
    public abstract class VehicleType
    {
        protected VehicleType(decimal basePremium)
        {
            BasePremium = basePremium;
        }
        public decimal BasePremium { get; private set; }
    }
}