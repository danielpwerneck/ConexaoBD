using System;
using System.Collections.Generic;
using Org.BouncyCastle.Asn1.Misc;
using Org.BouncyCastle.Pkcs;

namespace ConexaoBD
{
    class Program
    {
        static void Main(string[] args)

        {   
            Produto p2 = new Produto();
            p2.nome = "Camiseta";
            p2.preco = 109.90f;
            p2.Insere();

            Produto produto = new Produto();
            List<Produto> lista = produto.BuscaTodos();

            foreach(Produto p in lista)
            {
                Console.WriteLine("ID: "+p.id+" | Nome: "+p.nome);

            }

        }
    }
}
