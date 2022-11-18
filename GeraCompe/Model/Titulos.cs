using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeraCompe.Model
{
    internal class Titulos
    {
        public String codigoCliente { get; set; }
        public String valorPago { get; set; }
        public String seuNumero { get; set; }

        public Titulos(String codigoCliente, String valorPago, string seuNumero)
        {
            this.codigoCliente = codigoCliente;
            this.valorPago = valorPago;
            this.seuNumero = seuNumero;
        }

        public Titulos()
        {

        }
    }
}
