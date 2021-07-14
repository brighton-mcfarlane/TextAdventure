using System;
using System.Collections.Generic;
using System.Text;

namespace TextAdventure
{
    class Player
    {
        private string _name;
        private string _class;
        private int _health;
        private int _attackPower;
        private int _damageBooster;
        private int _sulfurisLevel;

        public Player()
        {

        }
        public Player(string playerName, string playerClass)
        {
            _name = playerName;
            _class = playerClass;
        }
        public string Name
        {
            get => _name;
            set => _name = value;
        }
        public string Class
        {
            get => _class;
            set => _class = value;
        }
        public int Health
        {
            get => _health;
            set => _health = value;
        }
        public int AttackPower
        {
            get => _attackPower;
            set => _attackPower = value;
        }
        public int DamageBooster
        {
            get => _damageBooster;
            set => _damageBooster = value;
        }
        public int SulfurisLevel
        {
            get => _sulfurisLevel;
            set => _sulfurisLevel = value;
        }

        public int AttackDamage()
        {
            Random rdm = new Random();
            return rdm.Next(0, AttackPower) + DamageBooster;
        }

    }
}
