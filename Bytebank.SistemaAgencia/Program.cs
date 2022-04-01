using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bytebank.SistemaAgencia
{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            

            Cliente carlos_1 = new Cliente();
            carlos_1.Nome = "Carlos";
            carlos_1.CPF = "458.623.120-03";
            carlos_1.Profissao = "Designer";

            Cliente carlos_2 = new Cliente();
            carlos_2.Nome = "Carlos";
            carlos_2.CPF = "458.623.120-03";
            carlos_2.Profissao = "Designer";

            ContaCorrente conta2 = new ContaCorrente(456, 87654);

            if (carlos_1.Equals(carlos_2)) {

                Console.WriteLine("São iguais");
            }
            else
            {
                Console.WriteLine("Não são iguais!!");
            }

            Console.ReadLine(); 




            // testando toString e classe object no console write line
            Console.WriteLine("Olá, Mundo");
            Console.WriteLine(123);
            Console.WriteLine(10.5);
            Console.WriteLine(true);

            Object conta = new ContaCorrente(456, 687876);
            Object desenvolvedor = new Desenvolvedor("1234567890");
            Console.WriteLine(conta);
            Console.WriteLine(desenvolvedor);

            string ContaToString = conta.ToString();

            Console.WriteLine("Resultado: "+ ContaToString);

            Console.ReadLine();
        }

        static void TestaString()
        {


            //string padrao = 
            //    "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            //string padraoRepeticao =
            //    "[0-9]{4,5}[-][0-9]{4}";
            //string padraoRepeticaoComZero =
            //    "[0-9]{4,5}-{0,1}[0-9]{4}";
            string padraoRepeticaoCoringa =
                "[0-9]{4,5}-?[0-9]{4}";
            string textoDeTeste =
                "Meu nome é Gabriel, me ligue em 94784-4546";

            Match resultado = Regex.Match(textoDeTeste, padraoRepeticaoCoringa);

            Console.WriteLine(resultado.Value);

            Console.ReadLine();




            //Testando Contains, Startswith e EndsWith
            string urlTeste = "https://www.bytebank.com/cambio";
            int indiceByteBank = urlTeste.IndexOf("https://www.bytebank.com");

            Console.WriteLine(urlTeste.StartsWith("https://www.bytebank.com"));
            Console.WriteLine(urlTeste.EndsWith("cambio/"));

            Console.WriteLine(urlTeste.Contains("Bytebank"));

            Console.ReadLine();


            string urlParametros = "http://www.bytebank.com/cambio?moedaOrigem=real&moedaDestino=dolar&valor=1500";
            ExtratorValordeArgumentosURL extratorDeValores = new ExtratorValordeArgumentosURL(urlParametros);


            string valor = extratorDeValores.GetValor("moedaDestino");
            Console.WriteLine("Valor de moedaDestino: " + valor);

            string valormoedaOrigem = extratorDeValores.GetValor("moedaOrigem");
            Console.WriteLine("Valor de moedaOrigem: " + valormoedaOrigem);

            Console.WriteLine("Valor:" + extratorDeValores.GetValor("VALOR"));

            Console.ReadLine();




            // testando ToUpper e ToLower
            string mensagemOrigem = "PALAVRA";
            string termoBusca = "ra";
            Console.WriteLine(mensagemOrigem.ToLower());

            Console.WriteLine(termoBusca.ToUpper());


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

        }
    }
}
