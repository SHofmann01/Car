using Car.Enums;
using Car.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    /// <summary>
    /// A stock of cars where cars can be booked in or booked out.
    /// </summary>
    public class CarStock
    {
        List<ICar> _carStock = new List<ICar>();

        public ICar GetCarByInventoryNr(int inventoryNr)
        {
            return _carStock.FirstOrDefault(c => c.InventoryNr == inventoryNr);
        }

        public ICar BookIn(ICar car)
        {
            if (car != null)
            {
                _carStock.Add(car);
                return car;
            }
            else
            {
                throw new ArgumentException("Error booking in the car. The car object is null.", "car");
            }
        }

        public ICar BookIn(int inventoryNr, Manufacturer manufacturer, int vintage, int maxSpeed)
        {
            try
            {
                var car = CarFactory.CreateCar(inventoryNr, manufacturer, vintage, maxSpeed);
                if (car != null)
                {
                    _carStock.Add(car);
                    return car;
                }
                else
                {
                    throw new Exception($"The car couldn't be created with the parameters: " +
                        $"inventoryNr = {inventoryNr}, manufacturer = {manufacturer}, vintage = {vintage}, maxSpeed = {maxSpeed}.");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ICar BookOut(ICar car)
        {
            try
            {
                if (car != null)
                {
                    _carStock.Remove(car);
                    return car;
                }
                else
                {
                    throw new Exception($"The car was not found in _carStock.");
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public ICar BookOut(int inventoryNr)
        {
            ICar car = _carStock.FirstOrDefault(c => c.InventoryNr == inventoryNr);
            return BookOut(car);
        }

        /// <summary>
        /// Lists the content of the car stock.
        /// </summary>
        public List<string> ShowInventory()
        {
            // Create inventory list.
            List<string> inventory = new List<string>();

            inventory.Add("Inventar-Nr | Marke | Jahrgang | Max Speed");
            inventory.Add("--------------------------------------------");
            foreach (var car in _carStock)
            {
                inventory.Add($"{car.InventoryNr} | {car.Manufacturer} | {car.Vintage} | {car.MaxSpeed}");
            }

            // Show inventory.
            foreach (var entry in inventory)
            {
                Console.WriteLine(entry);
            }

            return inventory;
        }
    }
}
