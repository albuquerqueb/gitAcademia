// See https://aka.ms/new-console-template for more information
/*
 * 4) Faça um programa em C# e no Visual Studio que adiciona dados na forma DDMMAAAA e imprima na
forma AAAAMMDD e AAMMDD. Note que o dia, o mês e o ano devem ser lidos em variáveis ​​diferentes.
*/

Console.WriteLine("Faça um programa em C# e no Visual Studio que adiciona dados na forma DDMMAAAA\n" +
    " e imprima na forma AAAAMMDD e AAMMDD.Note que o dia, o mês e o ano devem ser lidos em\n" +
    " variáveis ​​diferentes.");

int dia;
int mes;
int ano;

Console.WriteLine("Informa o dia: ");
dia = int.Parse(Console.ReadLine());

Console.WriteLine("Informa o mes: ");
mes = int.Parse(Console.ReadLine());

Console.WriteLine("Informa o ano: ");
ano = int.Parse(Console.ReadLine());

Console.WriteLine("DD/MM/AAAA: " +  dia + "/" + mes + "/" + ano);
Console.WriteLine("AAAA/MM/DD: " +  ano + "/" + mes + "/" + dia);

Console.WriteLine("AA/MM/DD: " + (ano | 100) + "/" + mes + "/" + dia);




