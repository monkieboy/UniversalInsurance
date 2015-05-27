namespace UniversalInsurance.RatingEngine
{
    public class Vehicle
    {
        public Manufacturer Manufacturer { get; set; }
        public VehicleClass Class { get; set; }
        public decimal Factor { get; set; }
    }
}