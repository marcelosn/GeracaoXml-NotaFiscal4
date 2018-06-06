using System;
using System.Collections.Generic;

namespace Nfe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var listaItens = new List<enviNFeNFeInfNFeDet>
            {
                new enviNFeNFeInfNFeDet
                {
                    nItem = 1,
                    prod = new enviNFeNFeInfNFeDetProd
                    {
                        cProd = 1,
                        CFOP = 5405,
                        qCom = 1
                    }
                },

                new enviNFeNFeInfNFeDet
                {
                    nItem = 2,
                    prod = new enviNFeNFeInfNFeDetProd
                    {
                        cProd = 2,
                        CFOP = 5102,
                        qCom = 2
                    }
                }
            };

            var nota =
                new enviNFe
                {
                    versao = 4,
                    NFe = new enviNFeNFe
                    {
                        infNFe =
                                new enviNFeNFeInfNFe
                                {
                                    dest = new enviNFeNFeInfNFeDest { xNome = "Matheus", email = "teste@teste.com" },
                                    det = listaItens
                                }
                    }
                };
            var xml = GerarXml<enviNFe>.Serialize(nota);

            Console.WriteLine(xml);
            Console.ReadLine();
        }
    }
}