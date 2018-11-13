using Zombie.Rpg.Classes.Controller;

namespace Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts.Wheels
{
    public sealed class Tire : VehiclePart
    {
        #region Private Fields
        private float airPresure;
        private float friction;
        #endregion

        /// <summary>
        /// Defines the size of the Tire
        /// </summary>
        public float Rim;
        /// <summary>
        /// [Property]  
        /// Defines the air presure in the Tire  
        /// (influences the Suspression and the Brakes)
        /// </summary>
        public float AirPresure{
            get{
                return airPresure;
            }
            set{
                airPresure = Rules.MaxValue(value);
            }
        }
        /// <summary>
        /// [Property]
        /// Defines the friction of the tires  
        /// Influences the Brakes
        /// </summary>
        public float Friction{
            get{
                return friction;
            }
            set{
                friction = Rules.MaxValue(value);
            }
        }

        public Tire(){
            Rim = 17;
            AirPresure = 0.5f;
            Friction = 0.5f;
        }
    }
}