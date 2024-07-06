using Car.Cars;
using Car.Enums;
using Car.Interfaces;

namespace Car
{
    /// <summary>
    /// Car factory that provides multiple configurations of cars.
    /// </summary>
    /// <remarks>
    /// 1. Zurzeit reicht eine Factory Klasse mit je einer Konfiguration pro Auto Marke.
    /// Aufgrund der Aufgabenstellung ist jedoch davon auszugehen, dass später weitere Marken hinzukommen könnten.
    /// 2. Man könnte später eine separate Factory Klasse pro Marke erstellen und alle Varianten pro Marke in dieser Klasse bereitstellen.
    /// </remarks>
    public static class CarFactory
    {
        public static ICar CreateCar(int inventoryNr, Manufacturer manufacturer, int vintage, int maxSpeed)
        {
            switch (manufacturer)
            {
                case Manufacturer.Ford:
                    return CreateFord(inventoryNr, vintage, maxSpeed);

                case Manufacturer.VW:
                    return CreateVW(inventoryNr, vintage, maxSpeed);

                default:
                    break;
            }
            return null;
        }

        /// <summary>
        /// Creates a Ford car with the parameters specified.
        /// </summary>
        /// <remarks>
        /// 1. Hier könnten die Räder und andere Bestandteile pro Factory Methode unterschiedlich konfiguriert werden.
        /// Aufgrund der Aufgabenstellung macht das jedoch wenig Sinn. Es müsste abgeklärt werden, ob die Räder austauschbar sein sollten (Public Setter Methode).
        /// 2. Da die Geschwindigkeitsbegrenzung für alle Ford Autos nicht realistisch wäre, wird diese Begrenzung nur in dieser Factory Methode implementiert. 
        /// </remarks>
        public static ICar CreateFord(int inventoryNr, int vintage, int maxSpeed)
        {
            if (maxSpeed < 50)
            {
                throw new ArgumentException($"The parameter maxSpeed is too low.", "maxSpeed");
            }

            if (maxSpeed > 250)
            {
                throw new ArgumentException($"The parameter maxSpeed is too high.", "maxSpeed");
            }

            return new Ford(inventoryNr, vintage, maxSpeed);
        }

        /// <summary>
        /// Creates a VW car with the parameters specified.
        /// </summary>
        /// <remarks>
        /// 1. Hier könnten die Räder und andere Bestandteile pro Factory Methode unterschiedlich konfiguriert werden.
        /// Aufgrund der Aufgabenstellung macht das jedoch wenig Sinn. Es müsste abgeklärt werden, ob die Räder austauschbar sein sollten (Public Setter Methode).
        /// 2. Da die Geschwindigkeitsbegrenzung für alle VW Autos nicht realistisch wäre, wird diese Begrenzung nur in dieser Factory Methode implementiert. 
        /// </remarks>
        public static ICar CreateVW(int inventoryNr, int vintage, int maxSpeed)
        {
            if (maxSpeed < 50)
            {
                throw new ArgumentException($"The parameter maxSpeed is too low.", "maxSpeed");
            }

            if (maxSpeed > 180)
            {
                throw new ArgumentException($"The parameter maxSpeed is too high.", "maxSpeed");
            }

            return new VW(inventoryNr, vintage, maxSpeed);
        }
    }
}
