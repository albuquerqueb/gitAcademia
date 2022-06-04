using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problemaGaragem
{ 
    class veiculo
{
    string placa;
    DateTime dataHoraEn;
   
    //private void gerarerEmail()
    //{
    //    string[] vetorDados = this.nomeCompleto.Split(' ');
    //    this.email = vetorDados[vetorDados.Length - 1] + "." + vetorDados[0] + "@ufn.edu.br";
    //    this.email = this.email.ToLower();
    //}

    ////construtor usado no cadastro de um usuario
    public veiculo(string placa)
    {
        this.placa = placa;
        
    }

    //construtor usado para popular a lista a partir do arquivo (banco)
    public veiculo(string placa, DateTime dataHoraEn)
    {
        this.placa = placa;
        this.dataHoraEn= dataHoraEn;
    }

    public string Placa { get => placa; set => placa = value; }

    public DateTime DataHoraEn { get => dataHoraEn; set => dataHoraEn = value; }
}
}