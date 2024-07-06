using Car.Enums;
using Car.Test.Mocks;

namespace Car.Test.Models
{
    [TestClass]
    public class BaseCarTest
    {
        [TestMethod]
        [DataRow(-1)]
        [DataRow(1000000001)]
        [ExpectedException(typeof(ArgumentException), "The parameter inventoryNr is invalid.")]
        public void BaseCarTest_InventoryNrIsInvalid_ThrowsException(int inventoryNr)
        {
            BaseCarMock baseCar = new BaseCarMock(inventoryNr, Manufacturer.Ford, 2000, 160);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The parameter vintage is invalid.")]
        public void BaseCarTest_VintageIsLessThan1900_ThrowsException()
        {
            BaseCarMock baseCar = new BaseCarMock(1000, Manufacturer.Ford, 1899, 180);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "The parameter vintage is invalid.")]
        public void CreateCarTest_VintageIsGreaterThanCurrentYear_ThrowsException()
        {
            BaseCarMock baseCar = new BaseCarMock(1000, Manufacturer.Ford, DateTime.Now.Year + 1, 180);
        }

        [TestMethod]
        public void BaseCarTest_Construct_WheelPositionsAreCorrect()
        {
            BaseCarMock baseCar = new BaseCarMock(1000, Manufacturer.Ford, 2000, 160);

            Assert.IsTrue(baseCar.FrontLeftWheel.Location == WheelLocation.FrontLeft);
            Assert.IsTrue(baseCar.FrontRightWheel.Location == WheelLocation.FrontRight);
            Assert.IsTrue(baseCar.RearLeftWheel.Location == WheelLocation.RearLeft);
            Assert.IsTrue(baseCar.RearRightWheel.Location == WheelLocation.RearRight);
        }
    }
}
