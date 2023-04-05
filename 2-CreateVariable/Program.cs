using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 2 - Criando Variáveis");

        int age;
        double wage;

        age = 27;
        wage = 30.14;


        Console.WriteLine("sua idade é: " + age);
        Console.WriteLine("seu salario sera de: $" + wage);

        //Console.Write("teste console write");


        double peso = 4.0;
        int quantidade = 10;
        Console.WriteLine(peso * quantidade);

        int brindes = 15;
        int pessoas = 2;
        Console.WriteLine(brindes / pessoas);

        int dia = 4;
        int outroDia = 4 + dia;
        Console.WriteLine(outroDia);

        double preco = 5.0;
        double ingressos = 5.0;
        Console.WriteLine(preco * ingressos);

        Console.WriteLine("Tecle enter para fechar...");
        Console.ReadLine();
    }
}