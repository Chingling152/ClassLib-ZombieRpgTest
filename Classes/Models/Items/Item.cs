namespace Zombie.Rpg.Classes.Models.Items
{
    public abstract class Item 
    {
        /// <summary>
        /// Defines the ID of the item
        /// </summary>
        public int ID;
        /// <summary>
        /// Defines the name of the item
        /// </summary>
        public string Name;
        /// <summary>
        /// Defines the description of the item
        /// </summary>
        public string Description;
        /// <summary>
        /// Defines the condition of the item (Affects almost everything)
        /// </summary>
        public float Status;
        /// <summary>
        /// The name of the icon of the Item
        /// </summary>
        public string IconName;// fix this
        /// <summary>
        /// Defines the weight of the item
        /// </summary>
        public float Weight;
    }
}