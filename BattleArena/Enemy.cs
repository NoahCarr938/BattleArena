using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Enemy : Character
    {
        string _name = "";
        float _maxHealth;
        float _health;
        float _attackPower;
        float _defensePower;

        public Enemy(string name, float maxHealth, float attackPower, float defensePower) : base()
        {
            _name = name;
            _maxHealth = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }
    } 
}
