using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using Newtonsoft.Json;

namespace Localizar_CEP
{
    class Program
    {
        enum Menu { Pesquisar = 1, Sair }
        static void Main(string[] args)
        {
            bool fechar = false;
            while (fechar == false)
            {
                Console.WriteLine("Pesquisar CEP\n++++++++++++");
                Console.WriteLine("1-Pesquisar CEP\n2-Sair");
                string optStr = Console.ReadLine();
                int optInt = int.Parse(optStr);
                Menu escolha = (Menu)optInt;

                if (optInt > 0 && optInt < 3)
                {
                    switch (escolha)
                    {
                        case Menu.Pesquisar:
                            Pesquisar();
                            break;
                        case Menu.Sair:
                            fechar = true;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Erro.");
                    Console.ReadLine();
                }

                Console.Clear();
            }
        }
        static void Pesquisar()
        {
            Console.WriteLine("Digite o CEP: ");
            int ncep = int.Parse(Console.ReadLine());
            string strURL = string.Format("https://viacep.com.br/ws/01001000/json/",ncep);

            var requisicao = WebRequest.Create(strURL);
            requisicao.Method = "GET";

            var resposta = requisicao.GetResponse();
            using (resposta)
            {
                var stream = resposta.GetResponseStream();
                StreamReader leitor = new StreamReader(stream);
                object dados = leitor.ReadToEnd();

                CEP cep = JsonConvert.DeserializeObject<CEP>(dados.ToString());
                cep.Exibir();

                stream.Close();
                resposta.Close();

                Console.ReadLine();
            }
        }
    }
}