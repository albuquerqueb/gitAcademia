// See https://aka.ms/new-console-template for more information

/*  Escreva um algoritmo para ler o número de eleitores de um município, o número de votos brancos, nulos\n
 *  e válidos. Calcule e escreva o percentual que cada um representa em relação ao total de eleitores.*/

int eleitores;
int brancos;
int nulo;
int valido;

Console.WriteLine("Digite o total de eleitores do seu municipio");
eleitores = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o total votos brancos do seu municipio");
brancos = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o total de votos nulos do seu municipio");
nulo = int.Parse(Console.ReadLine());

Console.WriteLine("Digite o total de votos validos do seu municipio");
valido = int.Parse(Console.ReadLine());

double percentualbrancos = (brancos * 100 / eleitores);
double percentualnulo = (nulo * 100 / eleitores);
double percentualvalido = (valido * 100 / eleitores);

Console.WriteLine("O Percentual de eleitores são: " + eleitores.ToString() + "%");
Console.WriteLine("O Percentual de votos brancos foi: " + brancos.ToString() + "%");
Console.WriteLine("O Percentual de votos nulo foi: " + nulo.ToString() + "%");
Console.WriteLine("O Percentual de votos valido foi: " + valido.ToString() + "%");




