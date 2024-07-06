using Car.Enums;
using Car.Interfaces;

namespace Car.Models
{
    /// <summary>
    /// The wheel of a car
    /// </summary>
    /// <remarks>
    /// In der Aufgabenstellung ist nicht klar, welche Aktivitäten im Zusammenhang mit Rädern in der Business-Domäne stattfinden.
    /// Aus diesem Grund ist zurzeit nur eine konkrete Rad Klasse modelliert. Man könnte jedoch weitere Logik hizufügen 
    /// und eine abstarkte Klasse daraus machen, von welcher man weitere spezifische Klassen ableitet, analog der BaseCar Klasse.
    /// </remarks>
    public class Wheel : IWheel
    {
        public WheelLocation Location { get; protected set; }

        public Wheel(WheelLocation location)
        {
            Location = location;
        }
    }
}
