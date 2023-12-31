using HotelariaJ.Hotel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Qual seu nome?");
        var nome = Console.ReadLine();

        Console.WriteLine("Seja Bem-Vindo, " + nome);
        Console.WriteLine("Agora informe a sua idade: ");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Ok, cadastro concluido!");

        CheckIn checkIn = new CheckIn();

        Quarto quarto = new Quarto();
       
        Console.ReadLine();
    }
}