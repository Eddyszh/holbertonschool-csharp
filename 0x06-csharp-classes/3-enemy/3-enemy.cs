﻿using System;

namespace Enemies
{
    /// <summary>
    /// Class named Zombie
    /// </summary>
    class Zombie
    {
        // Private field that has no value
        private int health;

        /// <summary>
        /// Public constructor, set the health value to 0
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Public constructor, set a value and throws an exception with a message
        /// </summary>
        public Zombie(int value)
        {
            if (value < 0) throw new System.ArgumentException("Health must be greater than or equal to 0");
            health = value;
        }

        /// <summary>
        /// Public method that returns the health of the zombies
        /// </summary>
        /// <return>
        /// The health of the zombie
        /// </return>
        public int GetHealth()
        {
            return health;
        }
    }
}
