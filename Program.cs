using System;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.Misc;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)

        {   

            Produto produto = new Produto();
            List<Produto> lista = produto.BuscaTodos();

            foreach(Produto p in lista)
            {
                Console.WriteLine("ID: "+p.id+" | Nome: "+p.nome);

            }

        }
    }
}
