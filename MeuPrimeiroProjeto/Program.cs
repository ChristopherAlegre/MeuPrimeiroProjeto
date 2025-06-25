using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Olá, meu nome é Christopher");

        Console.WriteLine("===== SOMA DE DOIS NÚMEROS =====");

        Console.Write("Digite o primeiro número: ");
        int numero1 = int.Parse(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        int numero2 = int.Parse(Console.ReadLine());

        Soma somar = new Soma();
        int resultado = somar.SomarDoisNumeros(numero1, numero2);

        Console.WriteLine("Resultado da soma: " + resultado);
    }
}

public class Soma
{
    public int SomarDoisNumeros(int a, int b)
    {
        return a + b;
    }
}
