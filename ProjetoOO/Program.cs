// See https://aka.ms/new-console-template for more information

Lampada l = new Lampada();
l.potencia = 9;
l.ligar();
Console.WriteLine("ligada? " + l.ligado + "potencia = " + l.potencia);
l.desligar(); 
Console.WriteLine("ligada? " + l.ligado + "potencia = " + l.potencia);
double n;
n = l.retornaPotencia();
Console.WriteLine("A potencia da lampada cadastrada = " + n);
Console.WriteLine("O retono da funlçao estaLigado = " l.estaLigado());
l.ligar();
l.desligar();
 if (l.estaLigado())
{
    Console.WriteLine("A lampada esta ligada!");
}
else
{
    Console.WriteLine("A lampada esta desligada");
}

public class Lampada
{

    public bool ligado;
    public double potencia;

    public void ligar()

    {
        Console.WriteLine("A lampada está sendo ligada! ");
        ligado = true;
    }
    public void desligar()
    {
        Console.WriteLine("A lampada está sendo desligada! ");
        ligado = false;
    }
    public double retornaPotencia()
        { return potencia; }    
    public bool estaLigado() 
    { 
        return ligado; 
    }
}

