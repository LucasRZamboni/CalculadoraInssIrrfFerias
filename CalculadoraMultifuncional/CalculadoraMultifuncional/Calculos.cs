using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraMultifuncional
{
    internal class Calculos
    {

        public static double salario, aliquota, aliquotaIrrf, aliquotaEfetiva, aliquotaEfetivaIrrf, inss,irrf, valorFinal,dependentes=0,valorDependentes, pensao=0;
        public static float f1 = 7.5f, f2 = 9f, f3 = 12f, f4 = 14f;
        public static float f01 = 0f, f02 = 7.5f, f03 = 15f, f04 = 22.5f, f05 = 27.5f;

        //INSS
        public static void CalculoFaixa1()
        {
            aliquota = (f1 / 100);
            inss = salario * aliquota;
            aliquotaEfetiva = (inss / salario) * 100;
            valorFinal = salario - inss;
        }
        public static void CalculoFaixa2()
        {
            aliquota = f2 / 100;

            inss = 90.90 + ((salario - 1212) * aliquota);
            aliquotaEfetiva = (inss / salario) * 100;
            valorFinal = salario - inss;

        }

        public static void CalculoFaixa3()
        {
            aliquota = f3 / 100;

            inss = 90.90 + 109.38 + ((salario - 2427) * aliquota);
            aliquotaEfetiva = (inss / salario) * 100;
            valorFinal = salario - inss;
        }
        public static void CalculoFaixa4()
        {
            aliquota = f4 / 100;

            inss = 90.90 + 109.38 + 145.64 + ((salario - 3641) * aliquota);
            aliquotaEfetiva = (inss / salario) * 100;
            valorFinal = salario - inss;
        }
        public static void CalculoTeto()
        {
            aliquota = f4 / 100;

            inss = 90.90 + 109.38 + 145.64 + 482.47;
            aliquotaEfetiva = (inss / salario) * 100;
            valorFinal = salario - inss;
        }

        //IRRF ----------------------------------------------------------------------------------------
        public static void CalculoFaixa01()
        {
            aliquotaIrrf = (f01 / 100);
            irrf = salario * aliquotaIrrf;
            aliquotaEfetivaIrrf = (irrf / salario) * 100;
            valorDependentes = dependentes * 189.59;

        }
        //SE(B5=0;0;SE(E(G14>1903,98;G14<2826,65);((G14-1903,98)*B5);
        //SE(E(G14>2826,65;G14<3751,05);((2826,65-1903,98)*K15)+((G14-2826,65)*B5);
        //SE(E(G14>3751,05;G14<4664,68);((2826,65-1903,98)*K15)+((3751,05-2826,65)*K16)+((G14-3751,05)*B5);
        //SE(G14>=4664,68;((2826,65-1903,98)*K15)+((3751,05-2826,65)*K16)+((4664,68-3751,05)*K17)+((G14-4664,68)*K18);"ERRO")))))
        public static void CalculoFaixa02()
        {
            aliquota = f2 / 100;

            inss = 90.90 + ((salario - 1212) * aliquota);
            aliquotaEfetiva = (inss / salario) * 100;
            valorFinal = salario - inss;

        }

        public static void CalculoFaixa03()
        {
            aliquota = f3 / 100;

            inss = 90.90 + 109.38 + ((salario - 2427) * aliquota);
            aliquotaEfetiva = (inss / salario) * 100;
            valorFinal = salario - inss;
        }
        public static void CalculoFaixa04()
        {
            aliquota = f4 / 100;

            inss = 90.90 + 109.38 + 145.64 + ((salario - 3641) * aliquota);
            aliquotaEfetiva = (inss / salario) * 100;
            valorFinal = salario - inss;
        }
        public static void CalculoFaixa05()
        {
            aliquota = f4 / 100;

            inss = 90.90 + 109.38 + 145.64 + 482.47;
            aliquotaEfetiva = (inss / salario) * 100;
            valorFinal = salario - inss;
        }
    }
}
