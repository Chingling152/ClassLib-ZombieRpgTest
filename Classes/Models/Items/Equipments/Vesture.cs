using Zombie.Rpg.Classes.Models.Inventory;

namespace Zombie.Rpg.Classes.Models.Items.Equipments.Container
{
    public class Vesture : Equipment
    {
        #region Stock
        /// <summary>
        /// Defines the maximum weight of the equipment 
        /// </summary>
        public float MaxWeight;
        /// <summary>
        /// Matrix with the number of slots for items
        /// </summary>
        public Slot[,] slots;
        #endregion

        #region Defense
        /// <summary>
        /// Defines the general Defense of the vesture 
        /// Is defined by the condition multiplied and the defense of the materials
        /// </summary>
        protected float damagedefense;
        /// <summary>
        /// Defines the defense against fire  
        /// Is defined by the condition multiplied and the defense of the materials
        /// </summary>
        protected float firedefense;
        /// <summary>
        /// Defines the defense against bullets , arrows and others protetiles  
        /// Is defined by the condition multiplied and the defense of the materials
        /// </summary>
        protected float projetiledefense;
        /// <summary>
        /// Defines the % of defense against bites   
        /// Is defined by the condition multiplied and the defense of the materials
        /// </summary>
        protected float bitedefense;
        /// <summary>
        /// Defines the defense against cold
        /// </summary>
        protected float temperature;
        #endregion
    }
}