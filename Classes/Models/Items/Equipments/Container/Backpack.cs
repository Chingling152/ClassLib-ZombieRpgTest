using Zombie.Rpg.Classes.Models.Inventory;

namespace Zombie.Rpg.Classes.Models.Items.Equipments.Container
{
    public class Backpack : Equipment
    {
        public float MaxWeight;
        public Slot[,] slots;
    }
}