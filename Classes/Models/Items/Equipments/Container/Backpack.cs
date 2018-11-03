using Zombie.Rpg.Classes.Models.Inventory;

namespace Zombie.Rpg.Classes.Models.Items.Equipments.Container
{
    public class Backpack : Vesture
    {
        /// <summary>
        /// Defines the weight % that will be reduced from the items inside the container
        /// </summary>
        public float WeightMultiplier;
    }
}