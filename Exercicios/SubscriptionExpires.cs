using System;

namespace ExerciciosCsharp.Exercicios;

class SubscriptionExpires
{
    static Random random = new Random();
    static int daysUntilExpiration;
    static int discountPercentage = 0;

    // Your code goes here

    public static void CheckSubscription()
    {
        daysUntilExpiration = random.Next(12);

        if (daysUntilExpiration <= 10 && daysUntilExpiration > 5)
        {
            Console.WriteLine($"Sua assinatura expira em {daysUntilExpiration} dias. Renove agora!");
        }
        else if(daysUntilExpiration <=5 && daysUntilExpiration > 1)
        {
            Console.WriteLine($"Sua assinatura expira em {daysUntilExpiration} dias! Renove agora e ganhe 10% de desconto!");
            discountPercentage = 10;
        }
        else if(daysUntilExpiration <= 1)
        {
            Console.WriteLine($"Sua assinatura expira em {daysUntilExpiration} dia! Renove agora e ganhe 20% de desconto!");
            discountPercentage = 20;
        }
        else if(daysUntilExpiration == 0)
        {
            Console.WriteLine("Sua assinatura expirou!");
        }


    }
}