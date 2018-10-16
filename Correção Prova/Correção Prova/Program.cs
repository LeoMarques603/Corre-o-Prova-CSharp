using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Correção_Prova
{
    class Program
    {
        //Questão 1
        static int Maior(int a, int b)
        {
            if (a > b)
            { return a; }

            else
            { return b; }
        }// Fim método maior

        //Questão 3
        static bool Par(int numero)
        {
            if (numero % 2 == 0)
                return true;
            else
                return false;
        }// Fim método par

    }// Fim classe program

}//Fim namespace
