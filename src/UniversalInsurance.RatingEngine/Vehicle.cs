namespace UniversalInsurance.RatingEngine
{
    public class Vehicle
    {
        public Manufacturer Manufacturer { get; set; }
        public IVehicleType Type { get; set; }
        public decimal BasePremium { get; set; }
    }
}