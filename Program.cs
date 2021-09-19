using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)

        {
            
            const double PI = Math.PI;
            const double G = 9.80665;

            double velocidade, angulo, alcance, altura;

            Console.WriteLine("\n---Projetil---\n");

            Console.Write("Informe a velocidade em m/s: ");
            velocidade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Informe o ângulo, em graus: ");
            angulo = Convert.ToDouble(Console.ReadLine());

            // Alcance 

            alcance = ((Math.Pow(velocidade, 2)) * Math.Sin((2 * angulo) * (PI / 180))) / G;

            Console.WriteLine($"\nalcance = {alcance:N2}");

            // altura 

            altura = Math.Pow(velocidade * Math.Sin(angulo * (PI / 180)), 2) / (2 * G);

            Console.WriteLine($"Altura Máxima = {altura:N2}\n");

        }
    }
}
