using System;

namespace Nfe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var item = new enviNFeNFeInfNFeDetProd { cProd = 1, CFOP = 5405, qCom = 1 };

            var nota =
                new enviNFe
                {
                    versao = 4,
                    NFe = new enviNFeNFe
                    {
                        infNFe =
                                new enviNFeNFeInfNFe
                                {
                                    dest = new enviNFeNFeInfNFeDest { xNome = "Matheus", email = "teste@teste.com" }
                                }
                    }
                };
            var xml = GerarXml<enviNFe>.Serialize(nota);

            Console.WriteLine(xml);
            Console.ReadLine();
        }
    }
}