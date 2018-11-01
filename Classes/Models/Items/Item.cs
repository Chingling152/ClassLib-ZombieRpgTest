using System.IO;

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
        public string description;
        /// <summary>
        /// Defines the condition of the item (May affect everything)
        /// </summary>
        public sbyte status;
        /// <summary>
        /// 
        /// </summary>
        public FileInfo icon;// fix this
        /// <summary>
        /// Defines the weight of the item
        /// </summary>
        public float Weight;
    }
}