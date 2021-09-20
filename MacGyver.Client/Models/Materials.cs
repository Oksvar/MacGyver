using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MacGyver.Client.Models
{
    public enum MaterialsType
    {
        
        Unknown = 0,
       
        Household = 1,
       
        Car = 2,
    }

    
    public abstract class Material
    {
        
        public abstract MaterialsType Type { get; }
    }

    #region Household 

    public class HairDryer: Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Household;
    }
    public class Fork: Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Household;
    }
    public class Toaster: Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Household;
    }
    public class Paint : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Household;
    }
    public class Rope : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Household;
    }
    public class Matchstick : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Household;
    }
    public class Knife : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Household;
    }
    public class DuctTape : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Household;
    }
    #endregion

    #region Car

    public class Rim : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Car;
    }
    public class WiperBlade : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Car;
    }
    public class BrakePad : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Car;
    }
    public class BrakeFluid : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Car;
    }
    public class Fuel : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Car;
    }
    public class Wheel : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Car;
    }
    public class Oil : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Car;
    }
    public class Glass : Material
    {
        public override MaterialsType Type { get; } = MaterialsType.Car;
    }

    #endregion
}
