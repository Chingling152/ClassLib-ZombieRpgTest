using Zombie.Rpg.Classes.Models.Inventory;

namespace Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Back
{
    public class Trunk : VehiclePart
    {
        public float MaxCapacity;
        public Slot[] slots;
        public TrunkLid Lid;
        public BackWindow window;
    }
}