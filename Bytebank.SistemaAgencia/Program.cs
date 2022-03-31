using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.SistemaAgencia
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar";
            ExtratorValordeArgumentosURL extratorDeValores = new ExtratorValordeArgumentosURL(urlParametros);

            
            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            Console.ReadLine();



            //Testando o remove
            string testeRemocao = "primeiraParte&parteParaRemover";
            int indiceEComercial = testeRemocao.IndexOf('&');
            Console.WriteLine(testeRemocao.Remove(indiceEComercial, 4));

            Console.ReadLine();

               


            // testando substring
            string palavra = "moedaOrigem=real&moedaDestino=dolar";
            string nomeArgumento = "moedaDestino";
            int indice = palavra.IndexOf(nomeArgumento);
            Console.WriteLine(indice);

            Console.WriteLine("Tamanho da string " + palavra.Length);

            Console.WriteLine(palavra.Substring(indice));
            //Lembre-se Substring é inclusivo, ou seja ele considera a partir da posição que é fornecida.
            Console.WriteLine(palavra.Substring(indice + nomeArgumento.Length + 1));
            Console.ReadLine();



            //Testando o IsNullOrEmpty
            string textoVazio = "";
            Console.WriteLine(String.IsNullOrEmpty(textoVazio));

            string textoNulo = null;
            Console.WriteLine(String.IsNullOrEmpty(textoNulo));

            string textoQualquqer = "Ave";
            Console.WriteLine(String.IsNullOrEmpty(textoQualquqer));

            Console.ReadLine();

            string url = "paginas?moedaOrigem=real&moedaDestino=dolar";

            int indiceInterrogacao = url.IndexOf('?');


            ExtratorValordeArgumentosURL extrator = new ExtratorValordeArgumentosURL("");


            


            Console.ReadLine();
        }
    }
}
