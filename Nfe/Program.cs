using System;

namespace Nfe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var item = new enviNFeNFeInfNFeDetProd { cProd = 1, CFOP = 5405, qCom = 1 };

            var cabecalho = new enviNFe { versao = 4 };
            var xml = GerarXml<enviNFe>.Serialize(cabecalho);

            Console.WriteLine(xml);
            Console.ReadLine();
        }
    }
}