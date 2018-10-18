using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_Prova
{// Questão 02
    class IMC
    {
        private double peso;
        private double altura;


        public IMC()
        {
            this.peso = 80.0;
            this.altura = 2.0;
        }// Fim IMC

        public IMC(double peso, double altura)
        {
            this.peso = peso;
            this.altura = altura;
        }

        public double Calcular(double peso, double altura)
        {
            return peso / (altura * altura);
        }

        public double Classificar(double imc)
        {
            if (Calcular < 16.0)
                return Console.WriteLine("Magreza Grave");

            if (16.0 > Calcular < 17.0)
                return Console.WriteLine("Magreza Moderada");

            if (17.0 > Calcular < 18.5)
                return Console.WriteLine("Magreza Leve");

            if (18.5 > Calcular < 25.0)
                return Console.WriteLine("Saudável");

            if (25.0 > Calcular < 30.0)
                return Console.WriteLine("Sobrepeso");

            if (30.0 > Calcular < 35.0)
                return Console.WriteLine("Obesidade Grau I");

            if (35.0 > Calcular < 40.0)
                return Console.WriteLine("Obesidade Grau II (Severa)");

            if (Calcular > 40)
                return Console.WriteLine("Obesidade Grau III (Mórbida)");
        }
    }
}
