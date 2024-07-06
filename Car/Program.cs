using Car.Enums;
using Car.Interfaces;

namespace Car
{
    /// <remarks>
    /// In der Aufgabenstellung ist die Business-Domöne etwas knapp beschrieben.
    /// Folgende Punkte müssten genauer abgeklärt werden, deshalb werden für die Aufgabenstellung Annahmen getroffen.
    /// 
    /// 1 - Haben alle Autos eine Autonummer, so dass beim Ausbuchen ein bestimmtes Auto aufgrund der Autonummer gesucht und ausgebucht werden kann ?
    /// Annahme: Es wird davon ausgegangen, dass es sich um ein Lager handelt, wo auch Autos ohne Autonummer gelagert werden. 
    /// Deshalb wird eine Inventarnummer pro Auto zugewiesen. 
    /// 
    /// 2 - Es ist nicht klar, zu welchem Zweck die Räder modelliert werden und welche Eigenschaften
    /// und Methoden relevant sind. Es wird jedoch gemäss Anforderung sichergestellt, dass jedem Rad eine Positions-Beschreibung wie "Vorne links" zugewiesen wird. 
    /// </remarks>
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create car stock.
            CarStock carStock = new CarStock();

            // Book-in cars.
            carStock.BookIn(1000, Manufacturer.VW, 1930, 90);
            carStock.BookIn(1001, Manufacturer.VW, 1940, 100);
            carStock.BookIn(1002, Manufacturer.VW, 1950, 110);
            carStock.BookIn(1003, Manufacturer.VW, 1960, 120);
            carStock.BookIn(1004, Manufacturer.VW, 1970, 130);
            carStock.BookIn(1005, Manufacturer.VW, 1980, 140);
            carStock.BookIn(1006, Manufacturer.VW, 1990, 150);
            carStock.BookIn(1007, Manufacturer.VW, 2000, 160);
            carStock.BookIn(1008, Manufacturer.VW, 2010, 170);
            carStock.BookIn(1009, Manufacturer.VW, 2020, 180);

            carStock.BookIn(1010, Manufacturer.Ford, 1932, 160);
            carStock.BookIn(1011, Manufacturer.Ford, 1942, 170);
            carStock.BookIn(1012, Manufacturer.Ford, 1952, 180);
            carStock.BookIn(1013, Manufacturer.Ford, 1962, 190);
            carStock.BookIn(1014, Manufacturer.Ford, 1972, 200);
            carStock.BookIn(1015, Manufacturer.Ford, 1982, 210);
            carStock.BookIn(1016, Manufacturer.Ford, 1992, 220);
            carStock.BookIn(1017, Manufacturer.Ford, 2002, 230);
            carStock.BookIn(1018, Manufacturer.Ford, 2012, 240);
            carStock.BookIn(1019, Manufacturer.Ford, 2022, 250);

            // Cars to test the BookOut method.
            carStock.BookIn(1020, Manufacturer.VW, 2021, 180);
            carStock.BookIn(1021, Manufacturer.Ford, 2023, 250);

            // Book-out cars.
            carStock.BookOut(1020);
            carStock.BookOut(1021);

            // Show inventory
            carStock.ShowInventory();

            Console.WriteLine();
            Console.WriteLine("Bitte eine Taste drücken, um zu beenden.");
            Console.ReadLine();
        }
    }
}
