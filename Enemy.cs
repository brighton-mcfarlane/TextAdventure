using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class Enemy
    {
        private string _name;
        private int _health;
        private int _attackStrength;

        public Enemy()
        {

        }
        public Enemy(string enemyName, int enemyHealth, int enemyAttackStrength)
        {
            _name = enemyName;
            _health = enemyHealth;
            _attackStrength = enemyAttackStrength;
        }
        public int AttackDamage()
        {
            Random rdm = new Random();
            return rdm.Next(0, _attackStrength);
        }
    }
}
