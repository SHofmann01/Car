using Car.Enums;
using Car.Models;

namespace Car.Test.Mocks
{
    /// <summary>
    /// BaseCar mock for testing.
    /// </summary>
    public class BaseCarMock : BaseCar
    {
        public BaseCarMock(int inventoryNr, Manufacturer manufacturer, int vintage, int maxSpeed)
            : base(inventoryNr, manufacturer, vintage, maxSpeed)
        {
        }
    }
}
