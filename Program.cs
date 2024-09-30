using ExerciciosCsharp.Exercicios;

Console.WriteLine("Selecione o exercício que deseja rodar:");
Console.WriteLine("1 - Jogar Dado");
Console.WriteLine("2 - Verificar Expiração da Assinatura");
Console.WriteLine("3 - FraudulentsIDsMatriz");
Console.WriteLine("4 - ForeachInventory");


string? escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        IfElse.JogarDado();
        break;
    case "2":
        SubscriptionExpires.CheckSubscription();
        break;
    case "3":
        MatrizFraudulentIds matrizFraudulentIds = new MatrizFraudulentIds();
        matrizFraudulentIds.setDefaultFraudulentsIds();
        matrizFraudulentIds.getFraudulentsIds();
        matrizFraudulentIds.setFraudulentsIDs("New001");
        matrizFraudulentIds.getFraudulentsIds();
        break;
    case "4":
        Inventory.sumInventory();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
