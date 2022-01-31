using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;
namespace exerciciosobs2_2
{
    class funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Impostos;

        public double SalarioLiquido()
        {
            return SalarioBruto - Impostos;
        }
        public void AumentoSalarial(double porcentagem)
        {
            double valor = SalarioBruto*(porcentagem/100);
            SalarioBruto = valor + SalarioBruto;
            
        }
        public override string ToString()
        {
            return "funcionario: " + Nome + ", salario R$" + SalarioLiquido();
        }

    }
}
