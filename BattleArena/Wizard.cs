﻿using System;
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

        // Wizard introduction
        public override void EnemyIntroduction(Character other)
        {
            Console.WriteLine("I am the head wizard of this city, let us fight already.");
        }

        public Wizard(string name, float maxHealth, float attackPower, float defensePower) : base("Wizard", 15, 20, 2)
        {
            _name = name;
            _maxHealth = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }
    }
}
