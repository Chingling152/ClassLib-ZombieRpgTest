namespace Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Back
{
    public class Muffler : VehiclePart
    {
        private float noise;
        
        /// <summary>
        /// Sets how high the noise will be
        /// Influenced by the NoiseMultiplier
        /// </summary>
        public float Noise{
            get {
                return noise * NoiseMultiplier;
            }
            set{
                noise = value;
            }
        }
        
        /// <summary>
        /// Increases (or mantain) the noise of the Muffler
        /// Influenced by status  
        /// **Min Value** : 0.5   
        /// </summary>
        public float NoiseMultiplier{
            get{
                return NoiseMultiplier;
            }
            set{
                if(value < 0.5f){
                    value = 0.5f;
                }

                NoiseMultiplier = value;
            }
        }
    }
}