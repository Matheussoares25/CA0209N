using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _0209N
{
    internal class Cliente
    {
        public int ID;
        public string[] nomeProduto = new string[100];
        public int[] quantidade = new int[100];
        public int totalProd = 0;

        public void Pedido()
        {
            Console.WriteLine("Estamos preparando seu pedido! Digite os produtos um por vez, na ordem correta das informações.");
            Console.WriteLine("Informe o nome do produto:");
            nomeProduto[totalProd] = Console.ReadLine();
            Console.WriteLine("Informe a quantidade:");
            quantidade[totalProd] = int.Parse(Console.ReadLine());
            totalProd++;
            Console.WriteLine("Deseja adicionar mais produtos ao seu pedido? (s/n)");
            string resposta = Console.ReadLine();
            while (resposta == "s")
            {
                Console.WriteLine("Informe o nome do produto:");
                nomeProduto[totalProd] = Console.ReadLine();
                Console.WriteLine("Informe a quantidade:");
                quantidade[totalProd] = int.Parse(Console.ReadLine());
                totalProd++;
                Console.WriteLine("Deseja adicionar mais produtos ao seu pedido? (s/n)");
                resposta = Console.ReadLine();
            }
            Console.WriteLine("Resumo do Pedido:");
            for (int i = 0; i < totalProd; i++)
            {
                Console.WriteLine("Produto: {0} || Quantidade: {1}", nomeProduto[i], quantidade[i]);
            }
        }
    }
}
