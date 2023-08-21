﻿using System;

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
    }
}
