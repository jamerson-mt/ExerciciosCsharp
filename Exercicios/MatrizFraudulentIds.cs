using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace ExerciciosCsharp.Exercicios
{
    public class MatrizFraudulentIds
    {
        string[] fraudulentsOrderIDs = new string[3];

        public void setDefaultFraudulentsIds()
        {
            fraudulentsOrderIDs[0] = "A123";
            fraudulentsOrderIDs[1] = "B456";
            fraudulentsOrderIDs[2] = "C789";
            // fraudulentsOrderIDs[3] = "D000";
        }
        public void getFraudulentsIds()
        {
            foreach (var id in fraudulentsOrderIDs)
            {
                if (id.ToLower().StartsWith("b"))
                {
                    Console.WriteLine($"Este Id: {id} é possivelmente fraudulento!");
                }
                else
                {
                    Console.WriteLine($"Este Id: {id} possivelmente não é fraudulento.");
                }

            }
        }
        public void setFraudulentsIDs(string id)
        {
            Console.WriteLine("em manutenção");
        }
    }
}