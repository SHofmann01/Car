using Car.Enums;
using Car.Models;

namespace Car.Cars
{
    /// <summary>
    /// Ford car with Ford specific properties and methods for -all- Ford cars.
    /// </summary>
    /// <remarks>
    /// 1. Initialisierungen und Validierungen, welche für alle Ford Autos gelten, werden in dieser Klasse einmal vorgenommen.
    /// 2. Es muss geklärt werden, ob pro Marke herstellerspezifische Eigenschaften und Funktionen erfasst werden müssen. 
    /// Es wird angenommen, dass auch herstellerspezifische Eigenschaften oder Methoden in Zukunft hinzukommen könnten.
    /// Wenn das nicht der Fall sein solte, könnte man auch mit nur einer konkreten Car Klasse auskommen und in der 
    /// Factory klasse die Eigenschaften pro Hersteller in unterschiedlichen Factory Methoden variieren.
    /// </remarks>
    public class Ford : BaseCar
    {
        public Ford(int inventoryNr, int vintage, int maxSpeed)
            : base(inventoryNr, Manufacturer.Ford, vintage, maxSpeed)
        {
        }
    }
}
