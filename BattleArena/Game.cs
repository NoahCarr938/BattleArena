using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Game
    {
        private bool _gameOver = false;

        private int GetInput(string description, string option1, string option2)
        {
            ConsoleKeyInfo key;
            int inputReceived = 0;

            while (inputReceived != 1 && inputReceived != 2)
            {
                // Print options
                Console.Clear();
                Console.WriteLine(description);
                Console.WriteLine("1." + option1);
                Console.WriteLine("2." + option2);
                Console.Write("> ");

                // Get input from player
                key = Console.ReadKey();
                
                // If first option
                if (key.KeyChar == '1')
                {
                    // Set input received to 1
                    inputReceived = 1;
                }
                // Otherwise if second option
                else if (key.KeyChar == '2')
                {
                    // Set input received to 2
                    inputReceived = 2;
                }
                // Else neither
                else
                {
                    // Display error message
                    Console.WriteLine("\nInvalid Input");
                    Console.ReadKey();
                }
            }
            Console.WriteLine();
            return inputReceived;
        }

        private void Start()
        {
            Character player = new Character(name: "Player", maxHealth: 100, attackPower: 10, defensePower: 5);
            Character enemy = new Character(name: "Enemy", maxHealth: 100, attackPower: 9, defensePower: 5);
            player.PrintStats();
            Console.WriteLine();
            enemy.PrintStats();

            // Loop until fight 1 is over.
            while (player.Health > 0 && enemy.Health > 0)
            {
                float damage = player.Attack(enemy);
                Console.WriteLine();
                Console.WriteLine(player.Name + " did " + damage + " to " + enemy.Name + "!");
                Console.WriteLine();
                enemy.Attack(player);
                Console.WriteLine();
                Console.WriteLine(enemy.Name + " did " + damage + " to " + player.Name + "!");
                Console.WriteLine();

                player.PrintStats();
                Console.WriteLine();
                enemy.PrintStats();
            }
            
        }

        private void Update()
        {

        }

        private void End()
        {

        }

        public void Run()
        {
            Start();
            while (!_gameOver)
            {
                Update();
            }
            End();
        }
    }
}
