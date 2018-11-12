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
        
        /// <summary>
        /// Creates an array with default Wheels
        /// </summary>
        /// <param name="size">Number of Wheels</param>
        /// <returns>An array with default Wheels</returns>
        public static Wheel[] CreateWheel(int size){
            Wheel[] Wheel = new Wheel[size];

            for (int i = 0; i < size-1; i++)
            {
                Wheel[i] = new Wheel();
            }
            return Wheel;
        }
        /// <summary>
        /// Creates an array with default Doors
        /// </summary>
        /// <param name="size">Number of Doors</param>
        /// <returns>An array with default Doors</returns>
        public static Door[] CreateDoor(int size){
            Door[] door = new Door[size];

            for (int i = 0; i < size-1; i++)
            {
                door[i] = new Door();
            }
            return door;
        }

        
    }

}