using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace problemaGaragem
{
    class Util

    {
        public static void exibirLista(string frase, List<veiculo> lista)
       
        {
            Console.WriteLine(frase);
            foreach (veiculo i in lista)
            {
                Console.WriteLine(i.Placa + " - " );
          
               
            }
        }

        public static void carregarListas(List<veiculo> lista)
        {
            StreamReader leitor;
            string nomeArquivo = "garagem.dat";
            string[] vetorDados;
            try
            {
                leitor = new StreamReader(nomeArquivo);
                do
                {
                    vetorDados = leitor.ReadLine().Split(";"); //placa;horaen
                    lista.Add(new veiculo(vetorDados[0], DateTime.Parse(vetorDados[1])));
                } while (!leitor.EndOfStream); //repete-se a leitura da linha até que o leitor não chegue no final do arquivo
            }
            catch (Exception e)
            {
                Console.WriteLine("Placa existente");
            }
        }

        private static bool jaCadastrado(veiculo objeto, List<veiculo> lista)
        {
            foreach (veiculo i in lista)
            {
                if (objeto.Placa.Equals(i.Placa))
                {
                    return true;
                }
            }
            return false;
        }

        private static void gravarArquivo(veiculo objeto)
        {
            try
            {
                StreamWriter escritor = new StreamWriter("garagem.dat", true);

                escritor.WriteLine(objeto.Placa + "-" + objeto.DataHoraEn);
                escritor.Flush();
                escritor.Close();
            }
            catch (Exception e)
            {
               
            }
        }


        public static void cadastrarVeiculo(string frase, List<veiculo> listaVeiculo)
        {
            Console.WriteLine(frase);
            string placa;

            Console.Write("Digite a placa: ");
            placa = Console.ReadLine();

            veiculo objeto = new veiculo(placa);

            listaVeiculo.Add(objeto);
            //gravar no arquivo
            Util.gravarArquivo(objeto);


        }
    }
}




