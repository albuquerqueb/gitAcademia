// See https://aka.ms/new-console-template for more information

/*
 * 2) Escreva um programa em C# e no Visual Studio para calcular uma média aritmética entre quatro números quaisquer
 * */


Console.WriteLine("Exercício 2: 2) Escreva um programa em C# e no Visual Studio\n" +
    " para calcular uma média aritmética entre quatro números quaisquer");

float numero1;
float numero2;
float numero3;
float numero4;
float media_aritmedica;

Console.Write("Infome o 1º número");
numero1 = float.Parse(Console.ReadLine());

Console.Write("Infome o 2º número");
numero2 = float.Parse(Console.ReadLine());

Console.Write("Infome o 3º número");
numero3 = float.Parse(Console.ReadLine());

Console.Write("Infome o 4º número");
numero4 = float.Parse(Console.ReadLine());

media_aritmedica = (numero1 + numero2 + numero3 + numero4);

Console.WriteLine("A média dos 4 valores é: " + media_aritmedica);