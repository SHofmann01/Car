using Car.Enums;
using Car.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Models
{
    /// <summary>
    /// Base Car with common properties and methods for -all- cars.
    /// </summary>
    /// <remarks>
    /// Initialisierungen und Validierungen, welche für alle Autos gelten, werden in dieser Klasse einmal vorgenommen.
    /// </remarks>
    public abstract class BaseCar : ICar
    {
        public int InventoryNr { get; protected set; }
        public Manufacturer Manufacturer { get; protected set; }
        public int Vintage { get; protected set; }
        public int MaxSpeed { get; protected set; }

        public Wheel FrontLeftWheel { get; protected set; } = new Wheel(WheelLocation.FrontLeft);
        public Wheel FrontRightWheel { get; protected set; } = new Wheel(WheelLocation.FrontRight);
        public Wheel RearLeftWheel { get; protected set; } = new Wheel(WheelLocation.RearLeft);
        public Wheel RearRightWheel { get; protected set; } = new Wheel(WheelLocation.RearRight);

        public BaseCar(int inventoryNr, Manufacturer manufacturer, int vintage, int maxSpeed)
        {
            if (inventoryNr < 0 || inventoryNr > 1000000000)
            {
                throw new ArgumentException($"The parameter inventoryNr is invalid.", "inventoryNr");
            }

            if (vintage < 1900 || vintage > DateTime.Now.Year)
            {
                throw new ArgumentException($"The parameter vintage is invalid.", "vintage");
            }

            this.InventoryNr = inventoryNr;
            this.Manufacturer = Manufacturer.Ford;
            this.Vintage = vintage;
            this.MaxSpeed = maxSpeed;
        }
    }
}
