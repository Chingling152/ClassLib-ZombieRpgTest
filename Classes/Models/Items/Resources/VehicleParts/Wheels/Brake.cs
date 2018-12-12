using Zombie.Rpg.Classes.Controller;

namespace Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Wheels
{
    public sealed class Brake : VehiclePart
    {
        /// <summary>
        /// Defines how much efective is the Brake
        /// </summary>
        public int Force{
            get{
                return Force;
            }
            set{
                Force = Rules.MaxValue(value);
            }
        }
        
    }
}