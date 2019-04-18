using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Microsoft.AspNetCore.App;
// using Microsoft.AspNetCore.Mvc.Testing;
using app_code.Controllers;

namespace app_code_tests.Tests
{
    [TestClass]
    public class AppCode_IsPrime
    {
        private readonly PrimeService _primeService;
        private readonly SampleDataController _sampleDataController;

        public AppCode_IsPrime()
        {
            _primeService = new PrimeService();
            _sampleDataController = new SampleDataController();
        }

        [TestMethod]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.IsFalse(result, "1 should not be prime");
        } 

        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(1)]
        public void ReturnFalseGivenValueOf2(int value)
        {
            var result = _primeService.IsPrime(value);

            Assert.IsFalse(result, $"{value} should not be a prime");
        }

        // [TestMethod]
        // public void WeatherForecastsList()
        // {
        //     var result = _sampleDataController.WeatherForecasts();

        //     Assert.IsNull(result, "WeatherForecasts failed to get data");
        // }

    }
}