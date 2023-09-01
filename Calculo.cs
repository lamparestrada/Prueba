using System.Diagnostics;
using System.Net.NetworkInformation;

namespace Calculadora

{

    class Notas
    {
        public double ponderado { get; set; }

        public Notas()
        {
            ponderado = 0;
        }
        public string Calculadora1(double quiz1, double taller1, double parcial1)
        {
            double Resultado_quiz = quiz1 * 0.05;
            double Resultado_taller = taller1 * 0.05;
            double Resultado_parcial1 = parcial1 * 0.20;
            double Final = Resultado_quiz + Resultado_taller + Resultado_parcial1;
            this.ponderado += Final;
            return $"su nota es {Final * 3.33333333} su ponderado es {Final}";

        }
        public string Calculadora2(double quiz2, double taller2, double parcial2)
        {
            double Resultado_quiz = quiz2 * 0.05;
            double Resultado_taller = taller2 * 0.05;
            double Resultado_parcial1 = parcial2 * 0.30;
            double Final = Resultado_quiz + Resultado_taller + Resultado_parcial1;

            this.ponderado += Final;
            return $"su nota es {Final * 2.5} su ponderado es {Final}";


        }
    }
}

