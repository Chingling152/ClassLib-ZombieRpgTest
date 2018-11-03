namespace Zombie.Rpg.Classes.Models.Items.Ammunition
{
    public class Magazine : Item
    {

        public byte Capacity;

        public byte MaxCapacity;

        public Bullet[] Ammo;
        public float BulletSize;
    }
}