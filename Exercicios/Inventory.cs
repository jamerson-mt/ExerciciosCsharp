using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosCsharp.Exercicios
{
    public class Inventory
    {
        static int[] inventory = { 200, 450, 700, 175, 250 };
        static int sum = 0;
        static int bin = 0;
        public static void sumInventory()
        {
            foreach (int items in inventory)
            {
                sum += items;
                bin++;
                Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
            }
            Console.WriteLine($"We have {sum} items in inventory.");
        }
    }
}