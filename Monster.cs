using System;

namespace ConsoleApp6
{
    public class Monster
    {
        private int damage;
		private float criticalChance; 
        protected int protect;
        protected int speed;
        
        public int Damage
        {
            get { return this.damage; }
            set { this.damage = value; }
        }
        private int armor;
        private int expirienceReward;
    }
}
