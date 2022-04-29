// See https://aka.ms/new-console-template for more information

/*
 * 1) Escreva um programa em C# e no Visual Studio para calcular a média aritmética entre números quaisquer.
*
*/
Console.WriteLine("Exercício 1: Escreva um programa em C# e no Visual Studio para calcular a média\n" +
                  "aritmética entre números quaisquer.");



float numero1;
float numero2;
float media_aritmedica;

Console.Write("Digite um número qualquer:  ");
numero1 = float.Parse(Console.ReadLine());

Console.Write("Digite um segundo número qualquer:  ");
numero2 = float.Parse(Console.ReadLine());

media_aritmedica = numero1 / numero2;

Console.WriteLine("A média arittmedica dos valores é de: " + media_aritmedica);
