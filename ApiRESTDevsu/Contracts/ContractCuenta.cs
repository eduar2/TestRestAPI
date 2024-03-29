﻿using System.ComponentModel.DataAnnotations;

namespace ApiRESTDevsu.Contracts
{
    public sealed class ContractCuenta
    {
        [Required]
        public string NumeroCuenta { get; set; }

        [Required]
        public string TipoCuenta { get; set; }

        [Required]
        public decimal SaldoInicial { get; set; }

        [Required]
        public decimal SaldoDisponible { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        public int ClienteId { get; set; }
    }

}
