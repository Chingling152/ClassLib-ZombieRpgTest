using Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts;
using Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Back;
using Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Front;

namespace Zombie.Rpg.Classes.Models.Instances.Vehicles
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Creates a default car  
        /// Color : black  
        /// Doors : 4  
        /// 
        /// </summary>
        public Car(){
            color = System.Drawing.Color.Black;
            wheel = Vehicle.CreateWheel(4);
            doors = Vehicle.CreateDoor(4);
            frontPart = new FrontPart();
            Body = new VehicleBody();
            trunk = new BackPart();
        }
    }
}