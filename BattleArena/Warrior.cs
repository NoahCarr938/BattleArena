using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Warrior : Enemy
    {
        string _name = "Warrior";
        float _maxHealth = 50;
        float _health = 50;
        float _attackPower = 5;
        float _defensePower = 5;


        public Warrior(string name, float maxHealth, float attackPower, float defensePower) : base(name, maxHealth, attackPower, defensePower)
        {
            _name = name;
            _maxHealth = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }
    }
}
