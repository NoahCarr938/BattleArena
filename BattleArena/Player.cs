using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Player : Character
    {
        string _name = "Player";
        float _maxHealth = 100;
        float _health = 100;
        float _attackPower = 10;
        float _defensePower = 5;

        public Player(string name, float maxHealth, float attackPower, float defensePower) : base("Player", 100, 10, 5)
        {
            _name = name;
            _maxHealth = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }
        // Warrior Introduction
        public override void Introduction()
        {
            //throw new NotImplementedException();
        }
    }
}
