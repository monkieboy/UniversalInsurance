using FluentAssertions;
using NUnit.Framework;

namespace UniversalInsurance.RatingEngine.Tests
{
    public class When_calculating_a_premium_and_applying_factors
    {
        [Test]
        public void Should_calculate_the_correct_value_for_the_vehicle_type_and_manufacturer()
        {
            var calc = new RatingCalculator();

            var premium = calc.GetRating(AudiCar);

            premium.Should().Be(800m);
        }

        private static Vehicle AudiCar
        {
            get
            {
                var vehicle = new Vehicle
                {
                    Manufacturer = Manufacturer.Audi,
                    Class = VehicleClass.Car
                };
                return vehicle;
            }
        }
    }
}
