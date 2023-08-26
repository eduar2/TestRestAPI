

using System.ComponentModel.DataAnnotations;

namespace ApiRESTDevsu.Contracts
{
    public sealed class ContractCliente : ContractPersona
    {
        [Required]
        public int IdCliente { get; set; }
        
        [Required]
        public string Contrasena { get; set; }
        
        [Required]
        public bool Estado { get; set; }

    } 

}
