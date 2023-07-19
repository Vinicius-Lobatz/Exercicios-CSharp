using System;
class conversor_Dolar_Real
{
    static void Main()
    {

        // Declarando as variáveis
        double cotDolar = 0, dolar = 0;

        //Apresentação da solução
        Console.WriteLine("Conversor de Dólar para Real C#\r");
        Console.WriteLine("------------------------\n");
        Console.WriteLine("\nInstrução: utilize virgula ao invés de ponto para declarar o valor");

        //Recebendo a cotação do dolár 
        Console.Write("\nPor favor insira a cotação atual do dólar:");
        cotDolar = Convert.ToDouble(Console.ReadLine());

        //Recebendo o valor em dolár
        Console.Write("\nAgora insira o valor em dólar:");
        dolar = Convert.ToDouble(Console.ReadLine()); 

        //Apresentando o valor em real 
        Console.WriteLine("\n------------------------");
        Console.WriteLine($"\nO valor convertido de dólar para real é R$ {dolar * cotDolar}");

        //Esperando o usuário finalizar a  aplicação
        Console.WriteLine($"\nPressione qualquer tecla para fechar a solução");
        Console.ReadLine();

    }
}
