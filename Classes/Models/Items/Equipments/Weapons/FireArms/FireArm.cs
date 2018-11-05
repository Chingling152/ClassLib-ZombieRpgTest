using Zombie.Rpg.Classes.Models.Items.Equipments.Weapons.WeaponAttachments;

namespace Zombie.Rpg.Classes.Models.Items.Equipments.Weapons.FireArms
{
    public class FireArm : Weapon
    {
        #region Stats
        /// <summary>
        /// 
        /// </summary>
        public float Cadence;
        /// <summary>
        /// 
        /// </summary>
        public float Recoil;
        #endregion  

        #region Ammunition
        /// <summary>
        /// 
        /// </summary>
        public bool isRacked;
        #endregion

        #region WeaponParts
        /// <summary>
        /// 
        /// </summary>
        public Sight sight;
        /// <summary>
        /// 
        /// </summary>
        public Barrel barrel;
        #endregion
    }
}