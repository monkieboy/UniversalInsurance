using System.Collections.Generic;
using FluentAssertions;
using NUnit.Framework;

namespace UniversalInsurance.RatingEngine.Tests
{
    public class When_calculating_a_premium_and_applying_factors
    {
        private readonly Car Car = new Car(basePremium: 800m);
        private readonly Van Van = new Van(basePremium: 1000m);

        private readonly Manufacturer Audi = new Manufacturer { Name = "Audi", Factor = 1.5m, };
        private readonly Manufacturer Mercedes = new Manufacturer { Name = "Mercedes", Factor = 2.0m, };
        private Vehicle AudiCar { get { return new Vehicle { Manufacturer = Audi, Type = Car }; } }
        private Vehicle AudiVan { get { return new Vehicle { Manufacturer = Audi, Type = Van }; } }
        private Vehicle MercedesVan { get { return new Vehicle { Manufacturer = Mercedes, Type = Van }; } }
        private Vehicle MercedesCar { get { return new Vehicle { Manufacturer = Mercedes, Type = Car }; } }

        [TestCaseSource("Vehicles")]
        public void Should_calculate_the_correct_premium_for_the_vehicle_type_and_manufacturer(Vehicle vehicle, decimal expectedPremium)
        {
            var calc = new RatingCalculator();

            var premium = calc.CalculatePremium(vehicle);

            premium.Should().Be(expectedPremium);
        }

        private IEnumerable<TestCaseData> Vehicles()
        {
            yield return new TestCaseData(AudiCar, 1200m);
            yield return new TestCaseData(AudiVan, 1500m);
            yield return new TestCaseData(MercedesVan, 2000m);
            yield return new TestCaseData(MercedesCar, 1600m);
        }

    }
}
