using ExerciciosCsharp.Exercicios;

Console.WriteLine("Selecione o exercício que deseja rodar:");
Console.WriteLine("1 - Jogar Dado");
Console.WriteLine("2 - Verificar Expiração da Assinatura");

string escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        IfElse.JogarDado();
        break;
    case "2":
        SubscriptionExpires.CheckSubscription();
        break;
    default:
        Console.WriteLine("Opção inválida.");
        break;
}
