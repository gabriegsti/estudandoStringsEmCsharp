using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.SistemaAgencia
{
    public class ExtratorValordeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get;}
        public ExtratorValordeArgumentosURL(string url)
        {
            if (String.IsNullOrEmpty(url))
            {
                throw new ArgumentNullException("O argumento url não pode ser nulo ou vazio", nameof(url));
            }
           
            int indiceInterrogacao = url.IndexOf('?');
            _argumentos= url.Substring(indiceInterrogacao+1);

        }

        //moedaOrigem = real & moedaDestino=dolar
        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);

            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceECormecial = resultado.IndexOf('&');
            
            if(indiceECormecial == -1)
            {
                return resultado;
            }

            return resultado.Remove(indiceECormecial);
        }

    }
}
