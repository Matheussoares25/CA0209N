using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace _0209N
{
    internal class Funcionario
    {
        public string registro;//ok
        public string salario;//ok
        public string função; //ok
        public string adimissao; //ok
        public double vr; //ok
        public double vt; //ok
        public double va; // ok
        public string assistencia_medica;
        public string carga_horaria;

        public void adimitir()
        {
            Console.WriteLine("Informe a data de adimissao");
            adimissao = Console.ReadLine();
            Console.WriteLine("Numero de Registro do Funcionario:");
            registro = Console.ReadLine();
            Console.WriteLine("Função exercida pelo funcionario:");
            função = Console.ReadLine();
            Console.WriteLine("Salario Base:");
            double salariofun = double.Parse(salario);
            Console.WriteLine("Qual a Carga Horaria");
            carga_horaria = Console.ReadLine();

            
        }
        public void beneficios()
        {
            Console.WriteLine("Valor do Vr Funcionario");
            Console.ReadLine ();
            Console.WriteLine("Valor do Vt funcionario:");
            Console.ReadLine();
            Console.WriteLine("Valor do Va Funcionario:");


        }

       
    }
}
