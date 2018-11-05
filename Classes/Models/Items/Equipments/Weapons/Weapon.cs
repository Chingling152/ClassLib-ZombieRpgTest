namespace Zombie.Rpg.Classes.Models.Items.Equipments.Weapons
{
    
    public class Weapon : Equipment
    {
        /// <summary>
        /// Defines how far the Weapon's attack is  
        /// </summary>
        public float Range;
        /// <summary>
        /// Defines the damage caused by the Weapon  
        /// It receives influence from the status and from the bullet status
        /// </summary>
        protected float Damage;
        /// <summary>
        /// Defines how far the noise can be heard
        /// </summary>
        protected float Noise;
    }
}