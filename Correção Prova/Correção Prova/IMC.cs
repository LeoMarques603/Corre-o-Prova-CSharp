using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_Prova
{
    class IMC
    {
        private double peso;
        private double altura;


        public IMC()
        {
            this.peso = 0.0;
            this.altura = 0.0;
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
            return 0.0;
        }
    }
}
