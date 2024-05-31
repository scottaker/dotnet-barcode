using NUnit.Framework;
using NUnit.Framework.Legacy;
using SimpleApi.API.Services;
using SimpleApi.Domain.Services;
using SimpleApi.Services.Models;
using SimpleApi.Tests.util;

namespace SimpleApi.Tests
{
    [TestFixture]
    public class BasicTests
    {
        [Test]
        public void Barcode_Generate()
        {
            var locator = GetLocator();
            var barcode = locator.Get<IBarcodeService>();
            var value = barcode.GenerateBarcode("038000356216");

            Console.WriteLine(value);
        }

        [Test]
        public void Get_Cities()
        {
            var service = new CityService();
            var cities = service.GetCities();

            ClassicAssert.IsNotNull(cities);
            ClassicAssert.IsNotEmpty(cities);

            Show(cities);
        }


        private void Show(IEnumerable<City> cities)
        {
            foreach (var city in cities)
            {
                Console.WriteLine($"{city.CityName,-30}\t{city.GpsCoordinates.Latitude} {city.GpsCoordinates.Longitude}");
            }
        }


        private ServiceLocator GetLocator()
        {
            return new ServiceLocator(null);
        }

    }
}
