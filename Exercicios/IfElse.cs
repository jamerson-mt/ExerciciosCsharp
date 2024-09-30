using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciciosCsharp.Exercicios
{
    public class IfElse
    {
        static Random dice = new Random();

        static int num1;
        static int num2;
        static int num3;
        static int points;

        public static void JogarDado()
        {
            num1 = dice.Next(1, 7);
            num2 = dice.Next(1, 7);
            num3 = dice.Next(1, 7);

            if (num1 == num2 && num2 == num3)
            {
                points = num1 + num2 + num3 + 6;
                Console.WriteLine("Você tirou um trio! Ganhou 6 pontos extra!");
                Console.WriteLine($"Você tirou primeiro dado: {num1}, segundo dado: {num2} e terceiro dado: {num3}! Total de pontos: {points} pontos!");
            }
            else if (num1 == num2 || num2 == num3 || num1 == num3)
            {
                points = num1 + num2 + num3 + 2;
                Console.WriteLine("Você tirou um par! Ganhou 2 pontos extra!");
                Console.WriteLine($"Você tirou primeiro dado: {num1}, segundo dado: {num2} e terceiro dado: {num3}! Total de pontos: {points} pontos!");
            }
            else
            {
                points = num1 + num2 + num3 ;
                Console.WriteLine("Você não tirou um trio ou um par! Ganhou 0 pontos extra!");
                Console.WriteLine($"Você tirou primeiro dado: {num1}, segundo dado: {num2} e terceiro dado: {num3}! Total de pontos: {points} pontos!");
            }

            if(points >= 15)
            {
                Console.WriteLine($"Você ganhou o jogo! {points} pontos!");
            }
            else
            {
                Console.WriteLine("Você perdeu o jogo!");
            }


        }
    }
}