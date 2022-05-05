// See https://aka.ms/new-console-template for more information

/* Um motorista de taxi deseja calcular o rendimento de seu carro na praça. Sabendo-se que o preço do combustível/n
 * é de R$6,90, escreva um algoritmo para ler a marcação do odômetro (marcador de quilometragem) no início do dia,/n
 * a marcação no final do dia, o número de litros de combustível gasto e o valor total (R$) recebido/n
 * dos passageiros. Calcule e escreva a média do consumo em Km/l e o lucro líquido do dia.*/

float odometroinicio;
float odometrofinal;
float litrosgasto;
float valorrecebeu;
float media;
float lucro;
float total;
float lucro;

Console.WriteLine("Informe seu marcador do odometro do inicio do dia");
odometroinicio = float.Parse(Console.ReadLine());

Console.WriteLine("Informe seu marcador do odometro do final do dia");
odometrofinal = float.Parse(Console.ReadLine());

Console.WriteLine("Informe os litros que foi utilizado no final do dia");
litrosgasto = float.Parse(Console.ReadLine());

Console.WriteLine("Informe valor que recebeu no final do dia");
valorrecebeu = float.Parse(Console.ReadLine());

total = odometroinicio + odometrofinal;

media = total / litrosgasto;

lucro = float.Parse(valorrecebeu - litrosgasto * 6,90()); 

Console.WriteLine("O total de Km/l consumido por dia é: " + total);

Console.WriteLine("A media consumida por dia é: " + media);

Console.WriteLine("O lucro no fim do dia foi: " + lucro);








