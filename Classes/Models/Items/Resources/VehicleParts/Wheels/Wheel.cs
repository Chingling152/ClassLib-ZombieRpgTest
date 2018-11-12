namespace Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Wheels
{
    public class Wheel : VehiclePart
    {
        public Tire tire;
        public Suspension suspension;
        public Brake brake;

        /// <summary>
        /// Creates a default Wheel 
        /// With default Tire , Brake and Suspension
        /// </summary>
        public Wheel(){
            tire = new Tire();
            suspension = new Suspension();
            brake = new Brake();
        }
    }
}