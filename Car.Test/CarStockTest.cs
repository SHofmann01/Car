using Car.Cars;
using Car.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Test
{
    [TestClass]
    public class CarStockTest
    {
        [TestMethod]
        public void GetCarByInventoryNrTest()
        {
            // Arrange
            CarStock carStock = new CarStock();
            var carInStock = carStock.BookIn(1000, Manufacturer.Ford, 1990, 180);

            // Act
            var foundCar = carStock.GetCarByInventoryNr(1000);

            // Assert
            Assert.IsNotNull(foundCar);
            Assert.AreSame(foundCar, carInStock);
        }

        [TestMethod]
        public void BookInTest_InsertCarObject_CarStockContainsCar()
        {
            // Arrange
            CarStock carStock = new CarStock();
            var carInStock = CarFactory.CreateFord(1000, 1990, 180);

            // Act
            carStock.BookIn(carInStock);
            var foundCar = carStock.GetCarByInventoryNr(1000);

            // Assert
            Assert.IsNotNull(foundCar);
            Assert.AreSame(foundCar, carInStock);
        }

        [TestMethod]
        public void BookInTest_InsertCarParametrized_CarStockContainsCar()
        {
            // Arrange
            CarStock carStock = new CarStock();


            // Act
            carStock.BookIn(1000, Manufacturer.VW, 1990, 180);
            var carInStock = carStock.GetCarByInventoryNr(1000);

            // Assert
            Assert.IsNotNull(carInStock);
            Assert.AreEqual(carInStock.InventoryNr, 1000);
            Assert.IsTrue(carInStock is VW);
            Assert.AreEqual(carInStock.Vintage, 1990);
            Assert.AreEqual(carInStock.MaxSpeed, 180);

        }

        [TestMethod]
        public void BookOutTest_BookoutCarByObject_CarIsNotInStock()
        {
            // Arrange
            CarStock carStock = new CarStock();
            var car = CarFactory.CreateFord(1000, 1990, 180);
            carStock.BookIn(car);

            // Act
            var foundCar = carStock.GetCarByInventoryNr(1000);
            Assert.IsNotNull(foundCar);

            carStock.BookOut(car);
            foundCar = carStock.GetCarByInventoryNr(1000);

            // Assert
            Assert.IsNull(foundCar);
        }

        [TestMethod]
        public void BookOutTest_BookoutCarByInventoryNr_CarIsNotInStock()
        {
            // Arrange
            CarStock carStock = new CarStock();
            var car = CarFactory.CreateFord(1000, 1990, 180);
            carStock.BookIn(car);

            // Act
            var foundCar = carStock.GetCarByInventoryNr(1000);
            Assert.IsNotNull(foundCar);

            carStock.BookOut(1000);
            foundCar = carStock.GetCarByInventoryNr(1000);

            // Assert
            Assert.IsNull(foundCar);
        }

        [TestMethod]
        public void ShowInventoryTest_ShowInventory_ReturnsInventory()
        {   
            // Arrange.
            CarStock carStock = new CarStock();
            carStock.BookIn(1000, Manufacturer.VW, 1930, 90);
            carStock.BookIn(1001, Manufacturer.VW, 1940, 100);
            carStock.BookIn(1010, Manufacturer.Ford, 1932, 160);
            carStock.BookIn(1011, Manufacturer.Ford, 1942, 170);

            // Act
            List<string> inventory = carStock.ShowInventory();

            // Assert

            // The appearance of the list may change, therefore only the count of the entries is checked.
            Assert.IsTrue(inventory.Count == 6); // 2 header and 4 car entries.
        }
    }
}
