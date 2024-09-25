using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Game
    {
        Character player = new Character(name: "Player", maxHealth: 100, attackPower: 10, defensePower: 5);
        Character Warrior = new Character(name: "Warrior", maxHealth: 50, attackPower: 8, defensePower: 5);
        Character Goblin = new Character(name: "Goblin", maxHealth: 25, attackPower: 10, defensePower: 3);
        Character Wizard = new Character(name: "Wizard", maxHealth: 15, attackPower: 20, defensePower: 2);
        Character Knight = new Character(name: "Knight", maxHealth: 80, attackPower: 15, defensePower: 8);
        private bool _gameOver = false;

        private string GetInput(string description, string option1, string option2, string option3)
        {
            string input = "";
            Console.ReadLine();
            string inputReceived = "";

            while (inputReceived != "fight" && inputReceived != "block" && inputReceived != "not attack")
            {
                // Print options
                Console.Clear();
                Console.WriteLine(description);
                Console.WriteLine(option1);
                Console.WriteLine(option2);
                Console.WriteLine(option3);
                Console.Write("> ");

                // Get input from player
               input = Console.ReadLine();
                
                // If first option
                if (input == "fight")
                {
                    // Set input received to fight
                    inputReceived = "fight";
                }
                // Otherwise if second option
                else if (input == "block")
                {
                    // Set input received to block
                    inputReceived = "block";
                }
                else if (input == "not attack")
                {
                    // Set input received to not attack
                    inputReceived = "not attack";
                }
                // Else neither
                else 
                {
                    // Display error message
                    Console.WriteLine("\nInvalid Input");
                    Console.ReadLine();
                }
            }
            Console.WriteLine();
            return inputReceived;
        }

        private void Start()
        {
            
            
        }

        private void Update()
        {
            player.PrintStats();
            Console.WriteLine();
            Warrior.PrintStats();

            

            // Loop until fight 1 is over.
            while (player.Health > 0 && Warrior.Health > 0)
            {
                string input = GetInput("How will you deal with the warrior?", "fight", "block", "not attack");
                Console.Write("> ");
                // If the player chooses to fight.
                if (input == "fight")
                {
                    float damage = player.Attack(Warrior);
                    Console.WriteLine();
                    Console.WriteLine(player.Name + " did " + damage + " to " + Warrior.Name + "!");
                    Console.WriteLine();
                    Warrior.Attack(player);
                    Console.WriteLine();
                    Console.WriteLine(Warrior.Name + " did " + damage + " to " + player.Name + "!");
                    Console.WriteLine();

                    player.PrintStats();
                    Console.WriteLine();
                    Warrior.PrintStats();
                }
            }

            // Solution to determine if the player moves on or not.
            if (player.Health <= 0)
            {
                // Player 2 dies
            }
            else if (Warrior.Health <= 0)
            {
                // Player 1 moves on
            }
        }

        private void End()
        {
            Console.WriteLine("Congrats, you have completed the battle arena!");
            _gameOver = true;
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
