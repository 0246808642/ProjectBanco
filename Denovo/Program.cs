using System.Globalization;
using System;
using System.Reflection.Metadata;
using Microsoft.AspNetCore.Routing.Constraints;
using System.Security.Cryptography.Xml;
using Microsoft.AspNetCore.Localization;
using Banco;


class Program
{
    static void Main(string[] args)
    {
        ContaBancaria p;
        Console.Write("Entre o número da conta: ");
        int NConta = int.Parse(Console.ReadLine());
        Console.Write("Entre o titular da conta: ");
        string Nome = Console.ReadLine();
        Console.Write("Haverá deposito inicial (s/n)? ");
        char Decisicao = char.Parse(Console.ReadLine());
        if(Decisicao == 's'|| Decisicao == 'S')
        {
            Console.Write("Entre o valor de depósito inicial: ");
            double Preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
             p = new ContaBancaria(Nome,NConta,Preco);

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p);

            Console.Write("Entre um valor para depósito: ");
            Preco = double.Parse(Console.ReadLine() ,CultureInfo.InvariantCulture);
            p.MetDeposito(Preco);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(p);

            Console.Write("Entre um valor para saque: ");
            Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.MetSaque(Preco);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(p);
        }
        else if (Decisicao == 'n' ||  Decisicao =='N')
        {
           p = new ContaBancaria(Nome, NConta);

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(p);

            Console.Write("Entre um valor para depósito: ");
            double Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.MetDeposito(Preco);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(p);

            Console.Write("Entre um valor para saque: ");
            Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            p.MetSaque(Preco);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:");
            Console.WriteLine(p);
        }

    }
}