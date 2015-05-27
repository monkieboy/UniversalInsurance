using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace UniversalInsurance.RatingEngine.Tests
{
    public class When_calculating_a_premium_and_applying_factors
    {
        [TestCaseSource("Vehicles")]
        public void Should_calculate_the_correct_premium_for_the_vehicle_type_and_manufacturer(Vehicle vehicle, decimal expectedPremium)
        {
            var calc = new RatingCalculator();

            var premium = calc.GetPremium(vehicle);

            premium.Should().Be(expectedPremium);
        }

        private static IEnumerable<TestCaseData> Vehicles()
        {
            yield return new TestCaseData(AudiCar, 1200m);
            yield return new TestCaseData(AudiVan, 1500m);
            yield return new TestCaseData(MercedesVan, 2000m);
            yield return new TestCaseData(MercedesCar, 1600m);
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
        private static Vehicle AudiVan
        {
            get
            {
                var vehicle = new Vehicle
                {
                    Manufacturer = Manufacturer.Audi,
                    Class = VehicleClass.Van
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
        private static Vehicle MercedesCar
        {
            get
            {
                var vehicle = new Vehicle
                {
                    Manufacturer = Manufacturer.Mercedes,
                    Class = VehicleClass.Car
                };
                return vehicle;
            }
        }
    }
}
