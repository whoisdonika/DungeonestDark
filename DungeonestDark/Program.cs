using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonestDark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int health = 100;
            int coins = 0;
            
            string[] rooms = Console.ReadLine().Split('|').ToArray();

            for (int i = 0; i < rooms.Length; i++)
            {
                string[] items = rooms[i].Split(' ');
                string item = items[0];
                int value = int.Parse(items[1]);

                if (item == "potion")
                {
                    if (health + value <= 100)
                    {
                        
                        health = health + value;
                    }
                    else
                    {
                        health = 100;
                    }

                    Console.WriteLine($"You healed for {value} hp.");
                    Console.WriteLine($"Current health : {health}");
                }
                else if (item == "chest")
                {
                    coins = coins + value;
                    Console.WriteLine($"You found {value} coins.");
                }
                else
                {
                    health = health - value;

                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {item}");
                        Console.WriteLine($"Current health : {health}");
                    }
                    else
                    {
                        Console.WriteLine($"You died! Killed by {item}!");
                         Console.WriteLine($"Best room : {i + 1}");
                    }
                }

                if (i == rooms.Length - 1 && health > 0)
                {
                    Console.WriteLine("You've made it!");
                    Console.WriteLine($"Coins : {coins}");
                    Console.WriteLine($"Health : {health}");
                }


            }
        }
    }
}
