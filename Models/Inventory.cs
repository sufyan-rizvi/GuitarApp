using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp1.Enums;
using GuitarApp1.Models;

namespace GuitarApp.Models
{
    internal class Inventory
    {
        public static List<Guitar> Guitars { get; set; } = new List<Guitar>();

        public static void AddGuitar(string serialNum, double price, Builder builder, string model, TypeE type, Wood backWood, Wood topWood, int numString)
        {
            Guitars.Add(new Guitar(serialNum, price, builder, model, numString, type, backWood, topWood));
        }

        public static Guitar GetGuitar(string serialNumber)
        {
            foreach (var guitar in Guitars)
            {
                if (guitar.SerialNumber == serialNumber)
                    return guitar;
            }
            return null;
        }

        public static List<Guitar> Search(GuitarSpec searchSpec)
        {
            List<Guitar> listGuitars = new List<Guitar>();
            foreach (var guitar in Guitars)
            {
                GuitarSpec currentSpec = guitar.GetSpec();
                if (currentSpec.Matches(guitar.Spec))
                    listGuitars.Add(guitar);
            }
            return listGuitars;
        }
    }
}
