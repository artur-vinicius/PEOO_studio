using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbastecimentoApp
{
    class Abastecimento
    {
        private double valorLitro;
        private double valorPago;
        private double kmRodados;

        public void SetValorLitro(double valorLitro)
        {
            if (valorLitro > 0) this.valorLitro = valorLitro;
        }

        public void SetValorPago(double valorPago)
        {
            if (valorPago > 0) this.valorPago = valorPago;
        }
        public void SetKmRodados(double kmRodados)
        {
            if (kmRodados > 0) this.kmRodados = kmRodados;
        }
        public double MediaKmLitro()
        {
            return kmRodados / (valorPago / valorLitro);
        }
        public double MediaReaisKm()
        {
            return valorPago / kmRodados;
        }
    }
}
