using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using GuitarApp1.Enums;

namespace GuitarApp1.Models
{
    internal class GuitarSpec
    {
        public Builder Builder { get; set; }
        public string Model { get; set; }
        public TypeE Type { get; set; }
        public Wood BackWood { get; set; }
        public Wood TopWood { get; set; }
        public int NumStrings {  get; set; }

        public GuitarSpec(Builder builder, string model,int numStrings, TypeE type, Wood backWood, Wood topWood)
        {
            Builder = builder;
            Model = model;
            Type = type;
            BackWood = backWood;
            TopWood = topWood;
            NumStrings = numStrings;
        }
        
        public int GetNumStrings()
        {
            return NumStrings;
        }
        public Builder GetBuilder()
        {
            return Builder;
        }

        public string GetModel()
        {
            return Model;
        }

        public TypeE GetType()
        {
            return Type;
        }

        public Wood GetBackWood()
        {
            return BackWood;
        }

        public Wood GetTopWood()
        {
            return TopWood;
        }

        public bool Matches(GuitarSpec otherSpec)
        {
            if (GetBuilder() != otherSpec.GetBuilder())
                return false;
            if (GetType() != otherSpec.GetType())
                return false;
            if (GetBackWood() != otherSpec.GetBackWood())
                return false;
            if (GetTopWood() != otherSpec.GetTopWood())
                return false;
            string model = otherSpec.GetModel().ToLower();
            if ((model != null) && (!model.Equals("") && (!model.Equals(GetModel().ToLower()))))
                return false;
            return true;
        }
    }
}
