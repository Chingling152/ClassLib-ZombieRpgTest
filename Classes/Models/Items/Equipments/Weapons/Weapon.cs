namespace Zombie.Rpg.Classes.Models.Items.Equipments.Weapons
{
    
    public class Weapon : Equipment
    {
        /// <summary>
        /// Defines how far the weapon's attack is  
        /// </summary>
        public float Range;
        /// <summary>
        /// Defines the damage caused by the weapon  
        /// It receives influence from the status
        /// </summary>
        protected float Damage;
        /// <summary>
        /// Defines how far the noise can be heard
        /// </summary>
        protected float Noise;
    }
}