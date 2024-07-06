using Car.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Interfaces
{
    /// <summary>
    /// The wheel of a car.
    /// </summary>
    ///  <remarks>
    /// 1. Aufgrund der Aufgabenstellung, Autos in einem Autolager ein-/ ausbuchen und inventarisieren zu können
    /// ist nicht klar, weshalb die Räder modelliert werden und die Position unterschieden werden muss. 
    /// Dies müsste zum Verständnis der Business-Domäne geklärt werden. Es wird angenommen, dass die Räder nicht 
    /// austauschbar sein müssen, da dies andernfalls als Anforderung aufgeführt worden wäre.
    /// 2. Rad Positionen sind als Enum modelliert, um eine einheitliche Bezeichnung durch starke Typisierung zu erhalten.
    /// </remarks>
    internal interface IWheel
    {
        WheelLocation Location { get; }
    }
}
