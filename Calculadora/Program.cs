using System;
using System.Globalization;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, porcentagem;

            Console.WriteLine("Digite o valor:");
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite a porcentagem:");
            porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (valor > 00.0)
            {
                porcentagem = (valor * porcentagem) / 100.0;
            }
            else
            {
                Console.WriteLine("Valor invalido");
            }

            double NovoValor = valor + porcentagem;

            Console.WriteLine("Valor da porcentagem: ");
            Console.WriteLine(porcentagem.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("valor somado com a porcentagem: ");
            Console.WriteLine(NovoValor.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}
