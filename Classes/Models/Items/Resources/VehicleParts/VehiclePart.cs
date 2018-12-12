using Zombie.Rpg.Classes.Models.Instances.Vehicles;

namespace Zombie.Rpg.Classes.Models.Items.Resources.VehicleParts
{
    public abstract class VehiclePart : Item
    {       
        /// <summary>
        /// Defines the architeture of the part  
        /// 
        /// </summary>
        public VehicleType PartType;
        /// <summary>
        /// Default Constructor of every VehiclePart
        /// </summary>
        public VehiclePart(){

        }

        public VehiclePart(int ID,string Name,string Desc,float Status,string IconName,float Weight,VehicleType PartType){
            this.ID = ID;
            this.Name = Name;
            this.Description = Desc;
            this.Status = Status;
            this.IconName = IconName;
            this.Weight = Weight;
            this.PartType = PartType;
        }
    }
}