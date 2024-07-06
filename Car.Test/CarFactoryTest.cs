using Car.Cars;
using Car.Enums;

namespace Car.Test
{
    [TestClass]
    public class CarFactoryTest
    {
        [TestMethod]
        public void CreateCarTest_ManufacturerIsFord_ReturnsFord()
        {
            var car = CarFactory.CreateCar(1000, Manufacturer.Ford, 1900, 180);

            Assert.IsNotNull(car);
            Assert.IsTrue(car is Ford);
            Assert.IsTrue(car.InventoryNr == 1000);
            Assert.IsTrue(car.Vintage == 1900);
            Assert.IsTrue(car.MaxSpeed == 180);
        }

        [TestMethod]
        public void CreateCarTest_ManufacturerIsVW_ReturnsVW()
        {
            var car = CarFactory.CreateCar(1001, Manufacturer.VW, 2000, 160);

            Assert.IsNotNull(car);
            Assert.IsTrue(car is VW);
            Assert.IsTrue(car.InventoryNr == 1001);
            Assert.IsTrue(car.Vintage == 2000);
            Assert.IsTrue(car.MaxSpeed == 160);
        }

        [TestMethod]
        [DataRow(49)]
        [DataRow(251)]
        [ExpectedException(typeof(ArgumentException), "The parameter maxSpeed is invalid.")]
        public void CreateFordTest_MaxSpeedIsInvalid_ThrowsException(int maxSpeed)
        {
            var car = CarFactory.CreateCar(1000, Manufacturer.Ford, 2000, maxSpeed);
        }

        [TestMethod]
        [DataRow(49)]
        [DataRow(181)]
        [ExpectedException(typeof(ArgumentException), "The parameter maxSpeed is invalid.")]
        public void CreateVWTest_MaxSpeedIsInvalid_ThrowsException(int maxSpeed)
        {
            var car = CarFactory.CreateCar(1000, Manufacturer.VW, 2000, maxSpeed);
        }
    }
}