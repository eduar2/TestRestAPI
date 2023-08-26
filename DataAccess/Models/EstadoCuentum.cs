using System;
using System.Collections.Generic;

#nullable disable

namespace DataAccess.Models
{
    public partial class EstadoCuentum
    {
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public string NumeroCuenta { get; set; }
        public string Tipo { get; set; }
        public decimal? SaldoInicial { get; set; }
        public bool Estado { get; set; }
        public decimal Valor { get; set; }
        public decimal SaldoDisponible { get; set; }
        public string Identificacion { get; set; }
    }
}
