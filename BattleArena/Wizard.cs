using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Wizard : Enemy
    {
        public string _name = "Wizard";
        public float _maxHealth = 10;
        public float _health = 10;
        public float _attackPower = 1;
        public float _defensePower = 1;

        public Wizard(string name, float maxHealth, float attackPower, float defensePower) : base(name, maxHealth, attackPower, defensePower)
        {
            _name = name;
            _maxHealth = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }
    }
}
