namespace Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Wheels
{
    public sealed class Suspension : VehiclePart
    {
        /// <summary>
        /// Defines the damping of the Suspension  
        /// Influences the control (and damage too) of the car in some terrain 
        /// </summary>
        public float Damping;
        /// <summary>
        /// Defines the compression of the Suspension
        /// </summary>
        public float Compression;
    }
}