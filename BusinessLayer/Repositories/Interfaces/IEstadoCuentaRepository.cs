using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace BusinessLayer.Repositories.Interfaces
{
    public interface IEstadoCuentaRepository: IGenericRepository<EstadoCuentum>
    {

        IEnumerable<EstadoCuentum> GetMovimientosPorFechaCliente(string identificacion, DateTime fechaInicial, DateTime fechaFinal);

    }
}
