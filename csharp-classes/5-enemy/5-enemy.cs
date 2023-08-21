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
        private int health;
        /// <summary>
        /// name field
        /// </summary>
        private string name = "(No name)";

        /// <summary>
        /// new propertie for name
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// new constructor for zombie
        /// </summary>
        public Zombie()
        {
            health = 0;
        }
        /// <summary>
        /// new constructor with one int parameter mandatory
        /// </summary>
        /// <param name="value">value gift to method</param>
        /// <exception cref="ArgumentException">if value is set to 0 or less, throw this exception</exception>
        public Zombie(int value)
        {
            if (value < 0)
                throw new ArgumentException("Health must be greater than or equal to 0");
            else
                health = value;
        }
        /// <summary>
        /// new method for return heatl value
        /// </summary>
        /// <returns>return the value of health field</returns>
        public int GetHealth()
        {
            return health;
        }
        /// <summary>
        /// print name and health of zombies created
        /// </summary>
        /// <returns></returns>
        public override string ToString() => $"Zombie Name: {name} / Total Health: {health}";


    }
}
