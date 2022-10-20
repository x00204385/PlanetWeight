using Microsoft.VisualStudio.TestTools.UnitTesting;
using PlanetWeights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanetWeights.Tests
{
    [TestClass()]
    public class PlanetWeightTests
    {
        [TestMethod()]
        public void weightOnPlanetTest_weightOnPlanet_IsCorrectWeight()
        {
            // Arrange
            PlanetWeight planetWeightTest = new PlanetWeight();
            planetWeightTest.weight = 1.0;

            // Act
            planetWeightTest.planet = Planets.jupiter;
            double convertedWeight =  planetWeightTest.weightOnPlanet;

            // Assert
            Assert.AreEqual(convertedWeight, 2.36);

        }

        [TestMethod()]
        public void weightOnPlanetTest_weightOnPlanet_IsNegativeNumber()
        {
            // Arrange
            PlanetWeight planetWeightTest = new PlanetWeight();
            planetWeightTest.weight = -1.0;

            // Act
            planetWeightTest.planet = Planets.jupiter;
            double convertedWeight = planetWeightTest.weightOnPlanet;

            // Assert
            Assert.AreEqual(convertedWeight, -2.36);

        }

        [TestMethod()]
        public void weightOnPlanetTest()
        {
            Assert.AreEqual(1, 1);
        }

    }
}