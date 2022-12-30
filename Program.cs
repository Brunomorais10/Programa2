using System;
using System.Globalization;

namespace Programa2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();
            
            
            Console.Write("Nome: ");
            f.Nome = Console.ReadLine();
            Console.Write("Salario bruto: ");
            f.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine("Funcionário: " + f);

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentag = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            f.AumentarSalario(porcentag);

            Console.WriteLine();
            Console.WriteLine("Dados atualizado: " + f);

        }
    }
}
