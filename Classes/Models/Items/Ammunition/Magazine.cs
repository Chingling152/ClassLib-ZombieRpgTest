namespace Zombie.Rpg.Classes.Models.Items.Ammunition
{
    public class Magazine : Item
    {

        /// <summary>
        /// Defines the capacity of Ammo in the Magazine
        /// </summary>
        public byte Capacity;
        /// <summary>
        /// A array with
        /// </summary>
        public Bullet[] Ammo;
        /// <summary>
        /// **readonly**
        /// Defines the type of Ammunition that fits on the Magazine
        /// </summary>
        public readonly Bullet BulletType;
    }
}