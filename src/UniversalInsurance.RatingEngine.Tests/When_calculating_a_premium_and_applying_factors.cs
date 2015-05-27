using FluentAssertions;
using NUnit.Framework;

namespace UniversalInsurance.RatingEngine.Tests
{
    public class When_calculating_a_premium_and_applying_factors
    {
        [Test]
        public void Should_calculate_the_correct_value_of_800_for_a_Audi_car()
        {
            var calc = new RatingCalculator();

            var premium = calc.GetRating(AudiCar);

            premium.Should().Be(800m);
        }

        [Test]
        public void Should_calculate_the_correct_value_of_2000_for_a_Mercedes_van()
        {
            var calc = new RatingCalculator();

            var premium = calc.GetRating(MercedesVan);

            premium.Should().Be(2000m);
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
        private static Vehicle MercedesVan
        {
            get
            {
                var vehicle = new Vehicle
                {
                    Manufacturer = Manufacturer.Mercedes,
                    Class = VehicleClass.Van
                };
                return vehicle;
            }
        }
    }
}
