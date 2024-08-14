using System.Diagnostics.CodeAnalysis;
using GuitarApp.Models;
using GuitarApp1.Enums;
using GuitarApp1.Models;

namespace GuitarApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inventory.AddGuitar("V95693", 1499.95, Builder.FENDER, "Startocastor", TypeE.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
            Inventory.AddGuitar("VF453", 1299.95, Builder.FENDER, "Startocastor", TypeE.ELECTRIC, Wood.ALDER, Wood.ALDER, 12);
            Guitar whatErinLikes = new Guitar("", 0, Builder.FENDER, "stratocastor", 12, TypeE.ELECTRIC, Wood.ALDER, Wood.ALDER);

            Inventory.Search(whatErinLikes.GetSpec()).ForEach(Console.WriteLine);

        }
    }
}
