using CalculatorSalarii.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace CalculatorSalarii.CalculeSalarii
{
    public static class Calcule
    {
        public static int SumaCAS(int salariu, double procentCAS)
        {
            double procentCalcul = procentCAS / 100;
            return (int)(Math.Round(Convert.ToDouble(salariu)  * procentCalcul));
        }

        public static int SumaCASS(int salariu, double procentCASS)
        {
            double procentCalcul = procentCASS / 100;
            return (int)(Math.Round(Convert.ToDouble(salariu) * procentCalcul));
        }

        public static int SumaDeducerePersonala(Angajat angajat)
        {
            int output;

            if (angajat.IsServiciuDeBaza is false || angajat.VenitBrut > 3600)
            {
                output = 0;
            }
            else
            {
                switch (angajat.NrPersoaneInIntretinere)
                {
                    case 0:
                        output = CuantumDeducere(510, angajat.VenitBrut);
                        break;
                    case 1:
                        output = CuantumDeducere(670, angajat.VenitBrut);
                        break;
                    case 2:
                        output = CuantumDeducere(830, angajat.VenitBrut);
                        break;
                    case 3:
                        output = CuantumDeducere(990, angajat.VenitBrut);
                        break;
                    case 4:
                        output = CuantumDeducere(1310, angajat.VenitBrut);
                        break;
                    default:
                        output = CuantumDeducere(1310, angajat.VenitBrut);
                        break;
                }
            }

            return output;
        }

        private static int CuantumDeducere(int deducereBaza, int venitBrut)
        {
            int output;

            if (venitBrut <= 1950)
            {
                output = deducereBaza;
            }
            else if (venitBrut > 3600)
            {
                output = 0;
            }
            else
            {
                output = deducereBaza - 15 * ((venitBrut + 49 - 1950) / 50);
            }

            return output;
        }

        public static int SumaImpozit(int venitBazaCalcul, double impozit)
        {
            double procentCalcul = impozit / 100;
            return (int)(Math.Round(Convert.ToDouble(venitBazaCalcul) * procentCalcul));
        }

        public static int SumaCAM(int salariu, double procentCAM)
        {
            double procentCalcul = procentCAM / 100;
            return (int)(Math.Round(Convert.ToDouble(salariu) * procentCalcul));
        }
    }
}
