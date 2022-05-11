/* 9 - Faça um programa no VS que inclua no usuário 3 valores de glicemia em reflexo, representando uma representação
         de glicemia diária de um paciente diabético. Para cada valor recebido: e informar ao paciente o seguinte
         Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
         Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.
         Além disso, o programa deve fazer a média dos 3 valores de glicemia avaliar. E se a média para
         menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média para maior que
         150, avisá-lo que será necessário adicionar 2 unidades de insulina.
   */
/// < resumo >
/// declarando variáveis
/// </ resumo >

double glicemia1, glicemia2, glicemia3, média;

/// < resumo >
/// Análise do primeiro dia, informando ao usuário o estado de sua glicemia usando condicionais de comparação
/// </ resumo >
Console.WriteLine(" Informe a glicemia do 1º dia: ");
glicemia1 = double.Parse(Console.ReadLine());
Console.Clear(); // comando para limpar a tela
Console.WriteLine(" Sua glicemia do 1º dia foi de: " + glicemia1);
if (glicemia1 < 65)
    {
    Console.WriteLine(" E você corre o risco de hipoglicemia. ");
}
if(glicemia1 > 250)
    {
    Console.WriteLine(" E você corre o risco de hipoglicemia. ");
}
if(glicemia1 > 60 && glicemia1 < 250)
    {
    Console.WriteLine(" E sua glicemia foi normal neste dia normal. ");
}


/// < resumo >
/// Análise do segundo dia, informando ao usuário o estado de sua glicemia usando condicionais de comparação
/// </ resumo >
Console.WriteLine(" \n Informe a glicemia do 2º dia: ");
glicemia2 = double.Parse(Console.ReadLine());
Console.Clear(); // comando para limpar a tela
Console.WriteLine(" Sua glicemia do 2º dia foi de: " + glicemia2);
if(glicemia2 < 65)
    {
    Console.WriteLine(" Você corre o risco de hipoglicemia. ");
}
if(glicemia2 > 250)
    {
    Console.WriteLine(" Você corre o risco de hipoglicemia. ");
}
if(glicemia2 > 60 && glicemia2 < 250)
    {
    Console.WriteLine(" E sua glicemia foi normal neste dia normal. ");
}

/// < resumo >
/// Analise do terceiro dia, informando ao usuário o estado de sua glicemia usando condicionais de comparação
/// </ resumo >
Console.WriteLine(" \n Informe a glicemia do 2º dia: ");
glicemia3 = double.Parse(Console.ReadLine());
Console.Clear(); // comando para limpar a tela
Console.WriteLine(" Sua glicemia do 3º dia foi de: " + glicemia3);
if(glicemia3 < 65)
    {
    Console.WriteLine(" Você corre o risco de hipoglicemia. ");
}
if(glicemia3 > 250)
    {
    Console.WriteLine(" Você corre o risco de hipoglicemia. ");
}
if(glicemia3 > 60 && glicemia3 < 250)
    {
    Console.WriteLine(" E sua glicemia foi normal neste dia normal. ");
}

média = (glicemia1 + glicemia2 + glicemia3) / 3; // calculando a média das glicemias diárias

/// < resumo >
/// Análise da mídia e informando ao usuário se é necessário aumentar a insulina ou não
/// </ resumo >
if(média < 80)
    {
    Console.Write(" A media é de: " + média + " . \n Reduza 2 unidades de insulina. ");
}
if(média > 150)
    {
    Console.Write(" A media é de: " + média + " . \n Aumente 2 unidades de insulina. ");
}


