// See https://aka.ms/new-console-template for more information

/*
 * Escreva uma seqüência de atribuições, em forma de programa em C# e no Visual Studio, para trocar entre
si os valores de duas variáveis ​​A e B.
*/


Console.WriteLine("Exercício 3: Escreva uma seqüência de atribuições, em forma de programa em\n" +
    " C# e no Visual Studio, para trocar entre\n" +
    "si os valores de duas variáveis ​​A e B.");

Console.WriteLine("Digite uma frase qualquer: ");
string varíavel1 = Console.ReadLine();


Console.WriteLine("Digite outra frase qualquer: ");
string varíavel2 = Console.ReadLine();

Console.Write("O conteudo da varíavel1 é: " + varíavel1);
Console.Write("O conteudo da varíavel2 é: " + varíavel2);

Console.WriteLine("Processo de troca de valores entre duas variáveis");

string tmp = varíavel1;
varíavel1 = varíavel2;
varíavel2 = tmp;


