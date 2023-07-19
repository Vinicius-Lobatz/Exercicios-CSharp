using System;
class calcula_Estoque
{
    static void Main()
    {

        //Declarando as variáveis
        double minimo = 0, maximo = 0;

        Console.WriteLine("Média de Estoque C#\r");
        Console.WriteLine("------------------------\n");

        //Recebendo os parametros do usuário
        Console.Write("\nDigite o minimo do estoque: ");
        minimo = Convert.ToDouble(Console.ReadLine());
        Console.Write("\nDigite o maximo do estoque: ");
        maximo = Convert.ToDouble(Console.ReadLine());

        //Saida para o usuário 
        Console.WriteLine("------------------------\n");
        Console.WriteLine($"\nMédia do estoque:{(minimo + maximo) / 2}");

        //Fechando a aplicação
        Console.WriteLine("------------------------\n");
        Console.WriteLine($"\nPressione qualquer tecla para sair");
        Console.ReadLine();

    }
}
