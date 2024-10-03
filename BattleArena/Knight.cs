using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Knight : Enemy
    {
        string _name = "Knight";
        float _maxHealth = 80;
        float _health = 80;
        float _attackPower = 15;
        float _defensePower = 8;


        // Knight introduction
        public override void EnemyIntroduction(Character other)
        {
            Console.WriteLine("I am a knight of the king, defeat me and you will survive the arena.");
        }
        

        public Knight(string name, float maxHealth, float attackPower, float defensePower) : base("knight", 80, 15, 8)
        {
            _name = name;
            _maxHealth = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }
    }
}
