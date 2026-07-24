using System;

namespace Enemies
{
    /// <summary>
    /// Defines a zombie enemy.
    /// </summary>
    public class Zombie
    {
        // The health points of the zombie.
        private int health;

        // The zombie's name; it defaults to "(No name)".
        private string name = "(No name)";

        /// <summary>
        /// Initializes a new zombie with zero health.
        /// </summary>
        public Zombie()
        {
            health = 0;
        }

        /// <summary>
        /// Initializes a new zombie with the supplied health.
        /// </summary>
        /// <param name="value">The initial health, which cannot be negative.</param>
        /// <exception cref="ArgumentException">Thrown when <paramref name="value"/> is negative.</exception>
        public Zombie(int value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }

            health = value;
        }

        /// <summary>
        /// Gets or sets the zombie's name.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets the current health of the zombie.
        /// </summary>
        /// <returns>The zombie's health value.</returns>
        public int GetHealth()
        {
            return health;
        }
    }
}
