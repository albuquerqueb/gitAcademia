// See https://aka.ms/new-console-template for more information

/*Escreva um programa em C# e no Visual Studio para calcular o consumo médio de um automóvel
(medido em Km/l), sendo que são conhecidos a distância total percorrida e o volume de combustível
consumo para percorrê-la (medido em l)
*
*/
Console.WriteLine("Exercicio 5: Escreva um programa em C# e no Visual Studio para calcular o consumo\n" +
    " médio de um automóvel (medido em Km / l), sendo que são conhecidos a distância total percorrida\n" +
    " e o volume de combustível consumo para percorrê - la(medido em l)");

float litro;
float km;
float media;

Console.WriteLine("Informe o km consumido por dia");
km = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o litro consumido por dia");
litro = int.Parse(Console.ReadLine());

media_aritmedica = (km * litro) / 1000;


