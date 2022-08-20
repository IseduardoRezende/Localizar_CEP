using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Localizar_CEP
{
    class CEP
    {
        public string cep;
        public string logradouro;
        public string complemento;
        public string bairro;
        public string localidade;
        public string uf;
        public int ibge;
        public int gia;
        public int ddd;
        public int siafi;

        public void Exibir()
        {
            Console.WriteLine("Aqui está: \n ===============");
            Console.WriteLine($"CEP: {cep}");
            Console.WriteLine($"Logradouro: {logradouro}");
            Console.WriteLine($"Complemento: {complemento}");
            Console.WriteLine($"Bairro: {bairro}");
            Console.WriteLine($"Localidade: {localidade}");
            Console.WriteLine($"UF: {uf}");
            Console.WriteLine($"IBGE: {ibge}");
            Console.WriteLine($"GIA: {gia}");
            Console.WriteLine($"DDD: {ddd}");
            Console.WriteLine($"SIAFI: {siafi}");
        }
    }
}
