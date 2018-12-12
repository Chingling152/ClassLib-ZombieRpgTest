namespace Zombie.Rpg.Classes.Controller
{
    public static class Rules
    {
        /// <summary>
        /// Returns the number if it's in the inclusive range  
        /// </summary>
        /// <param name="value">The float number to be checked</param>
        /// <returns>Returns 0 if it is less than 0 and 1 if it is greater than 1</returns>
        public static float MaxValue(float value){
            if(value < 0) value = 0;
            if(value > 100f) value = 100f;
            return value;
        }

        public static int MaxValue(int value){
            if(value < 0) value = 0;
            if(value > 100) value = 100;
            return value;
        }
    }
}