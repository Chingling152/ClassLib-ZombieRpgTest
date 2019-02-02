namespace Zombie.Rpg.Classes.Models.Items.Equipments.Container
{
    public class Armor : Vesture
    {
        /// <summary>
        /// Defines the weight % that will be reduced from the items inside the container  
        /// 1.0 = -100% of weight  
        /// -1.0 = +100% of weight 
        /// </summary>
        public float WeightMultiplier;
        
    }
}