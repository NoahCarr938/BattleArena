using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace BattleArena
{
    internal class Character
    {
        private string _name = "Character";
        private float _maxHealth = 10;
        private float _health = 10;
        private float _attackPower = 1;
        private float _defensePower = 1;

        public virtual string Name {  get { return _name; } }
        public virtual float MaxHealth {  get { return _maxHealth; } }
        public virtual float Health
        {
            get { return _health;  }
            private set { _health = Math.Clamp(value, 0, _maxHealth);  }
        }

        public virtual float AttackPower { get { return _attackPower; } }

        public virtual float DefensePower { get { return _defensePower; } }
        public Character()
        {

        }
        public Character(string name, float maxHealth, float attackPower, float defensePower)
        {
            _name = name;
            _maxHealth = maxHealth;
            _health = maxHealth;
            _attackPower = attackPower;
            _defensePower = defensePower;
        }

        public virtual float Attack(Character other)
        {
            float damage = MathF.Max(0, _attackPower - other.DefensePower);
            other.TakeDamage(damage);
            return damage;
        }

        public virtual void TakeDamage(float damage)
        {
            Health -= damage;
            if (Health == 0)
            {
                Die();
            }
        }

        public void Heal(float health)
        {
            Health += health;
        }

        public virtual void Die()
        {
            Console.WriteLine(Name + " has died!");
        }

        public virtual void PrintStats()
        {
            Console.WriteLine("Name:          "          + Name);
            Console.WriteLine("Health:        "        + Health + "/" + MaxHealth);
            Console.WriteLine("Attack Power:  "  + AttackPower);
            Console.WriteLine("Defense Power: " + DefensePower);
        }
    }
}
