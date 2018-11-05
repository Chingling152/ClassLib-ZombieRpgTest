using Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts;
using Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Back;
using Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Doors;
using Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Front;
using Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Wheels;

namespace Zombie.Rpg.Classes.Models.Instances.Vehicles
{
    /// <summary>
    /// 
    /// </summary>
    public enum VehicleType{
        Standard,
        Sport,
        HeavyDuty
    }
    /// <summary>
    /// 
    /// </summary>   
    public abstract class Vehicle
    {
        public System.Drawing.Color color;
        public VehicleType vehicleType;

        public Wheel[] wheel;
        public Door[] doors;
        public FrontPart frontPart;
        public VehicleBody Body;
        public BackPart trunk;
    }

}