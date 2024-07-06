using Car.Enums;
using Car.Models;

namespace Car.Cars
{
    /// <summary>
    /// VW car with VW specific properties and methods for -all- VW cars.
    /// </summary>
    /// <remarks>
    /// 2. Initialisierungen und Validierungen, welche für alle VW Autos gelten, werden in dieser Klasse einmal vorgenommen.
    /// Es muss geklärt werden, ob pro Marke herstellerspezifische Eigenschaften und Funktionen erfasst werden müssen. 
    /// Es wird angenommen, dass auch herstellerspezifische Eigenschaften oder Methoden in Zukunft hinzukommen könnten.
    /// Wenn das nicht der Fall sein solte, könnte man auch mit nur einer konkreten Car Klasse auskommen und in der 
    /// Factory klasse die Eigenschaften pro Hersteller in unterschiedlichen Factory Methoden variieren.
    /// </remarks>
    public class VW : BaseCar
    {
        public VW(int inventoryNr, int vintage, int maxSpeed)
            : base(inventoryNr, Manufacturer.VW, vintage, maxSpeed)
        {
        }
    }
}
