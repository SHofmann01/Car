using Car.Enums;
using Car.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car.Interfaces
{
    /// <summary>
    /// A car for transporting people.
    /// </summary>
    /// <remarks>
    /// 1. Bei der objektorientierten Programmierung versucht man intelligente Objekte zu kreieren, 
    /// welche ihre wichtigsten Daten kennen und diese auch selbständig manipulieren können. 
    /// In diesem einfachen Beispiel wurden essenzielle Aspekte eines Autos wie beschleunigen, 
    /// bremsen, steuern nach links / rechts etc. nicht modelliert, da diese für die Problemstellung nicht relevant sind. 
    /// 2. Private und Protected Methoden und Properties können auch in Interfacves definiert werden, 
    /// sofern eine Default-Implementation bereitgestellt wird. Aus Übersichtlichkeitsgründen 
    /// wird jedoch die Implementation in die Basisklasse verschoben.
    /// </remarks>
    public interface ICar
    {
        int InventoryNr { get; }
        Manufacturer Manufacturer { get; }
        int Vintage { get; }
        int MaxSpeed { get; }

        Wheel FrontLeftWheel { get; }
        Wheel FrontRightWheel { get; }
        Wheel RearLeftWheel { get; }
        Wheel RearRightWheel { get; }
    }
}
