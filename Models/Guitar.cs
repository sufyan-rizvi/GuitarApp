using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuitarApp1.Enums;
using GuitarApp1.Models;

namespace GuitarApp.Models
{
    internal class Guitar
    {
        public string SerialNumber { get; set; }
        public double Price { get; set; }
        public GuitarSpec Spec { get; set; }
        public Guitar(string serNo, double price, Builder builder, string model, int numStrings, TypeE type, Wood backWood, Wood topWood)
        {
            SerialNumber = serNo;
            Price = price;
            Spec = new GuitarSpec(builder, model, numStrings, type, backWood, topWood);
        }

        public string GetSerialNumber()
        {
            return SerialNumber;
        }
        public double GetPrice()
        {
            return Price;
        }

        public void SetPrice(float number)
        {
            Price = number;
        }

        public GuitarSpec GetSpec()
        {
            return Spec;
        }

        public override string ToString()
        {
            return $"We have a {Spec.Builder.ToString()} {Spec.Model} {Spec.NumStrings}- {Spec.Type.ToString()} guitar !\n" +
                $"{Spec.BackWood.ToString()} back and sides,\n" +
                $"{Spec.TopWood.ToString()} top.\n" +
                $"You can have it for only ${Price}";
        }
    }
}
