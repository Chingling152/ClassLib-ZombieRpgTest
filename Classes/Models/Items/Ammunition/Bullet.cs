namespace Zombie.Rpg.Classes.Models.Items.Ammunition
{
    public class Bullet : Item
    {
        /// <summary>
        /// **[Read Only]**  
        /// Defines the size of the bullet  
        /// Used by magazine  
        /// </summary>
        public readonly float Size;
        /// <summary>
        /// Defines the damage of the bullet  
        /// Is defined by the status
        /// </summary>
        public float Damage;
    }
}