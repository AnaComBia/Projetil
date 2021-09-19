using System;

namespace Projetil
{
    class Program
    {
        static void Main(string[] args)

        {
            // Da constante π (pi) = 3,14159 radianos
            // Da constante g = 9,80665 m/s²
            // Converter o ângulo de graus para radianos, como no exemplo: 180° × π/180 = 3rad
            // Aplicar a Equação de Torricelli para o alcance, e
            // Aplicar a equação de Torricelli para a altura.

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
