using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal abstract class Enemy 
    {
        string _name = "";
        float _maxHealth;
        float _health;
        float _attackPower;
        float _defensePower;
        bool enemyIsAlive = true;

        // Abstract function to introduce enemies.
        public abstract void EnemyIntroduction();


        public Enemy(string name, float maxHealth, float attackPower, float defensePower)
        {
            _name = name;
            _maxHealth = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }
    } 
}
