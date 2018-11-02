namespace Zombie.Rpg.Classes.Models.Items.Consumables
{
    public abstract class Consumable : Item
    {
        /// <summary>
        /// Defines how many times the item can be used.
        /// </summary>
        public byte Quantity;
    }
}