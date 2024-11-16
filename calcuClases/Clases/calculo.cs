using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcuClases.Clases
{
    public class calculo
    {
        public double Calcular(string Op, double N1, double N2)
        {
            double Res = 0;
            switch (Op)
            {
                case "+":
                    Res = Sumar(N1, N2);
                    break;

                case "-":
                    Res = Restar(N1, N2);
                    break;
                    
                case "*":
                    Res = Multiplicar(N1, N2);
                    break;
                    
                case "/":
                    Res = Dividir(N1, N2);
                    break;
                    

            }

            return Res;



        }
        
        
            private double Dividir(double N1, double N2)
            {
                double D;
                D = N1 / N2;
                return D;

            }

            private double Multiplicar(double N1, double N2)
            {
                double M;
                M = N1 * N2;
                return M;

            }

            private double Restar(double N1, double N2)
            {
                double R;
                R = N1 - N2;
                return R;

            }
            private double Sumar(double N1, double N2)
            {
                double S;
                S = N1 + N2;
                return S;

            }

        

    }
}
