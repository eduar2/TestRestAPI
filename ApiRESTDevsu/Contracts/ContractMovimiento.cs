using System;
using System.ComponentModel.DataAnnotations;
using System.Text; 

namespace ApiRESTDevsu.Contracts
{
    public sealed class ContractMovimiento
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public DateTime Fecha { get; set; }

        [Required]
        public string TipoMovimiento { get; set; }

        [Required]
        public decimal Valor { get; set; }

        [Required]
        public decimal Saldo { get; set; }

        [Required]
        public string NumeroCuenta { get; set; } 
               

    }
}
