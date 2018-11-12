namespace Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Wheels
{
    public class Tire : VehiclePart
    {
        /// <summary>
        /// 
        /// </summary>
        public float Rim;
        /// <summary>
        /// 
        /// </summary>
        public float AirPresure;
        /// <summary>
        /// 
        /// </summary>
        public float Friction;

        public Tire(){
            Rim = 17;
            AirPresure = 0.5f;
            Friction = 0.5f;
        }
    }
}