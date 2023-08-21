using System;

namespace Enemies
{
/// <summary>
/// New class zombie
/// </summary>
    public class Zombie

    {
        /// <summary>
        /// health field
        /// </summary>
        public int health;
        /// <summary>
        /// new constructor for zombie
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
        }
    }
}
