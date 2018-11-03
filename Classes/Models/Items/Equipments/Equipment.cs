using Zombie.Rpg.Classes.Models.Items.Materials;
using System.Collections.Generic;

namespace Zombie.Rpg.Classes.Models.Items.Equipments
{
    public abstract class Equipment : Item
    {
        /// <summary>
        /// List of materials that the object is Composed
        /// </summary>
        public List<Material> materials;
        
        /// <summary>
        /// Defines the general resistance of the Equipment  
        /// Is defined by the condition multiplied and the resistance of the materials
        /// </summary>
        protected float resistance;
    }
}