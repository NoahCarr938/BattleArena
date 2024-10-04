using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BattleArena
{
    internal class Game
    {
        Character player = new Enemy(name: "Player", maxHealth: 100, attackPower: 10, defensePower: 5);
        Enemy Warrior = new Enemy(name: "Warrior", maxHealth: 20, attackPower: 8, defensePower: 3);
        Enemy Goblin = new Enemy(name: "Goblin", maxHealth: 25, attackPower: 10, defensePower: 3);
        Enemy Wizard = new Enemy(name: "Wizard", maxHealth: 15, attackPower: 12, defensePower: 2);
        Enemy Knight = new Enemy(name: "Knight", maxHealth: 40, attackPower: 10, defensePower: 4);
        private bool _gameOver = false;
        int currentArea = 1;
        bool playerIsAlive = true;

        int GetInput(string description, string option1, string option2, string option3)
        {
            string input = "";
            Console.ReadLine();
            int inputReceived = 0;
            

            while (inputReceived != 1 && inputReceived != 2 && inputReceived != 3)
            {
                // Print options
                Console.Clear();
                Console.WriteLine(description);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                Console.WriteLine("3. " + option3);
                Console.Write("> ");

                // Get input from player
                input = Console.ReadLine();

                // If first option
                if (input == "1" || input == option1)
                {
                    // Set input received to fight
                    inputReceived = 1;
                }
                // Otherwise if second option
                else if (input == "2" || input == option2)
                {
                    // Set input received to block
                    inputReceived = 2;
                }
                else if (input == "3" || input == option3)
                {
                    // Set input received to not attack
                    inputReceived = 3;
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
        void Room1()
        {


            player.PrintStats();
            Console.WriteLine();
            Warrior.PrintStats();
            Warrior.Introduction();


            // Loop until fight 1 is over.
            while (player.Health > 0 && Warrior.Health > 0)
            {
                int input = GetInput("How will you deal with the warrior?", "fight", "block", "not attack");
                Console.Write("> ");
                // If the player chooses to fight.
                if (input == 1)
                {
                  
                    float damage = player.Attack(Warrior);
                    Console.WriteLine();
                    Console.WriteLine(player.Name + " did " + damage + " to " + Goblin.Name + "!");
                    Console.WriteLine();
                    Warrior.Attack(player);
                    Console.WriteLine();
                    Console.WriteLine(Warrior.Name + " did " + damage + " to " + player.Name + "!");
                    Console.WriteLine();

                    player.PrintStats();
                    Console.WriteLine();
                    Warrior.PrintStats();
                }
                // If the player chooses to block
                else if (input == 2)
                {
                    float damage = player.Block(Warrior);
                    Console.WriteLine();
                    Console.WriteLine(Warrior.Name + " did " + damage + " to " + player.Name + "!");
                    Console.WriteLine();

                    player.PrintStats();
                    Console.WriteLine();
                    Warrior.PrintStats();
                }
                // If the player chooses not to attack
                else if (input == 3)
                {
                    float damage = player.NotAttack(Warrior);
                    Console.WriteLine();
                    Console.WriteLine(Warrior.Name + " did " + damage + " to " + player.Name + "!");

                }
            }
            

        }
        void Room2()
        {
            Console.Clear();
            player.PrintStats();
            Console.WriteLine();
            Goblin.PrintStats();
            Goblin.Introduction();

            while (player.Health > 0 && Goblin.Health > 0)
            {
                int input = GetInput("How will you deal with the goblin?", "fight", "block", "not attack");
                Console.Write("> ");
                // If the player chooses to fight.
                if (input == 1)
                {
                    float damage = player.Attack(Goblin);
                    Console.WriteLine();
                    Console.WriteLine(player.Name + " did " + damage + " to " + Goblin.Name + "!");
                    Console.WriteLine();
                    Goblin.Attack(player);
                    Console.WriteLine();
                    Console.WriteLine(Goblin.Name + " did " + damage + " to " + player.Name + "!");
                    Console.WriteLine();

                    player.PrintStats();
                    Console.WriteLine();
                    Goblin.PrintStats();
                }
                // If the player chooses to block
                else if (input == 2)
                {
                    float damage = player.Block(Goblin);
                    Console.WriteLine();
                    Console.WriteLine(Goblin.Name + " did " + damage + " to " + player.Name + "!");
                    Console.WriteLine();

                    player.PrintStats();
                    Console.WriteLine();
                    Goblin.PrintStats();
                }
                // If the player chooses not to attack
                else if (input == 3)
                {
                    float damage = player.NotAttack(Goblin);
                    Console.WriteLine();
                    Console.WriteLine(Goblin.Name + " did " + damage + " to " + player.Name + "!");

                }
            }
        }
        void Room3()
        {
            Console.Clear();
            player.PrintStats();
            Console.WriteLine();
            Wizard.PrintStats();
            Wizard.Introduction();

            while (player.Health > 0 && Wizard.Health > 0)
            {
                int input = GetInput("How will you deal with the wizard?", "fight", "block", "not attack");
                Console.Write("> ");
                // If the player chooses to fight.
                if (input == 1)
                {
                    float damage = player.Attack(Wizard);
                    Console.WriteLine();
                    Console.WriteLine(player.Name + " did " + damage + " to " + Wizard.Name + "!");
                    Console.WriteLine();
                    Wizard.Attack(player);
                    Console.WriteLine();
                    Console.WriteLine(Wizard.Name + " did " + damage + " to " + player.Name + "!");
                    Console.WriteLine();

                    player.PrintStats();
                    Console.WriteLine();
                    Wizard.PrintStats();
                }
                // If the player chooses to block
                else if (input == 2)
                {
                    float damage = player.Block(Wizard);
                    Console.WriteLine();
                    Console.WriteLine(Wizard.Name + " did " + damage + " to " + player.Name + "!");
                    Console.WriteLine();

                    player.PrintStats();
                    Console.WriteLine();
                    Wizard.PrintStats();
                }
                // If the player chooses to not attack
                else if (input == 3)
                {
                    float damage = player.NotAttack(Wizard);
                    Console.WriteLine();
                    Console.WriteLine(Wizard.Name + " did " + damage + " to " + player.Name + "!");

                }
            }
        }
        void Room4()
        {
            Console.Clear();
            player.PrintStats();
            Console.WriteLine();
            Knight.PrintStats();
            Knight.Introduction();


            while (player.Health > 0 && Knight.Health > 0)
            {
                int input = GetInput("How will you deal with the knight?", "fight", "block", "not attack");
                Console.Write("> ");
                // If the player chooses to fight.
                if (input == 1)
                {
                    float damage = player.Attack(Knight);
                    Console.WriteLine();
                    Console.WriteLine(player.Name + " did " + damage + " to " + Knight.Name + "!");
                    Console.WriteLine();
                    Knight.Attack(player);
                    Console.WriteLine();
                    Console.WriteLine(Knight.Name + " did " + damage + " to " + player.Name + "!");
                    Console.WriteLine();

                    player.PrintStats();
                    Console.WriteLine();
                    Knight.PrintStats();
                }
                // if the player chooses to block
                else if (input == 2)
                {
                    float damage = player.Block(Knight);
                    Console.WriteLine();
                    Console.WriteLine(Knight.Name + " did " + damage + " to " + player.Name + "!");
                    Console.WriteLine();

                    player.PrintStats();
                    Console.WriteLine();
                    Knight.PrintStats();
                }
                // if the player chooses to not attack
                else if (input == 3)
                {
                    float damage = player.NotAttack(Knight);
                    Console.WriteLine();
                    Console.WriteLine(Knight.Name + " did " + damage + " to " + player.Name + "!");
                   
                }
            }
        }

        // The end of the game
        void Room5()
        {
            if (player.Health > 0)
            {
                Console.Clear();
                Console.WriteLine("Congrats, you have completed the battle arena!");
            }
        }

        private void Start()
        {
            Enemy player = new Enemy(name: "Player", maxHealth: 100, attackPower: 10, defensePower: 5);
            Enemy Warrior = new Enemy(name: "Warrior", maxHealth: 20, attackPower: 8, defensePower: 3);
            Enemy Goblin = new Enemy(name: "Goblin", maxHealth: 25, attackPower: 10, defensePower: 3);
            Enemy Wizard = new Enemy(name: "Wizard", maxHealth: 15, attackPower: 12, defensePower: 2);
            Enemy Knight = new Enemy(name: "Knight", maxHealth: 40, attackPower: 10, defensePower: 4);

        }

        private void Update()
        {
            // Room Loop
            while (!_gameOver)
            {
                if (currentArea == 1)
                {
                    Room1();
                }
                if (currentArea == 2)
                {
                    Room2();
                }
                if (currentArea == 3)
                {
                    Room3();
                }
                if (currentArea == 4)
                {
                    Room4();
                }
                if (currentArea == 5)
                {
                    Room5();
                }

                // While the game is over display main menu
                if (playerIsAlive == false || currentArea == 5)
                {
                    _gameOver = true;
                }
                // If the game is not over move forward
                else
                {
                    currentArea++;
                }

                if (player.Health <= 0)
                {
                    _gameOver = true;
                }
            }

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
