using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0209N
{
    internal class Pessoa
    {
        public string Nome;
        public string CPF;
        public string Endereço;
        public string Estado_Civil;
        public string Telefone;


        public void Cadastrar()
        {
            Console.WriteLine("Digite seu Nome: ");
            Nome = Console.ReadLine();
            Console.WriteLine("Digite seu CPF: ");
            CPF = Console.ReadLine();
            Console.WriteLine("Digite seu Endereço: ");
            Endereço = Console.ReadLine();
            Console.WriteLine("Digite seu Estado CIvil: ");
            Estado_Civil = Console.ReadLine();
            Console.WriteLine("Digite seu Telefone: ");
            Telefone = Console.ReadLine();


        }
        public void Consultar()
        {
            Console.WriteLine("\n Informações da Pessoa");
            Console.WriteLine($"Nome: {Nome} ");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Endereço: {Endereço}");
            Console.WriteLine($"Estado Civil: {Estado_Civil}");
            Console.WriteLine($"Telefone: {Telefone}");

        }

    }

    }
