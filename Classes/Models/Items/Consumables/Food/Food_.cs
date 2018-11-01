namespace Zombie.Rpg.Classes.Models.Items.Consumables.Food
{
    public abstract class Food_ : Consumable
    {
        #region Safety
            public int DaysToRotten;
            public bool isRotten;
            public float Hapinness;
        #endregion

        #region Nutrition  
            public float Carbohydrates;
            public float Nutrition;
            public float Fat;
            public float Calories;
        #endregion
        #region Hungry and Tirst
            public float Hungry;
            public float Thirst;
        #endregion
    }
}