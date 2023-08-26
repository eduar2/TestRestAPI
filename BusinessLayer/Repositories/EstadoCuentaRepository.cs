using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using DataAccess.Models;
using BusinessLayer.Repositories.Interfaces;

namespace BusinessLayer.Repositories
{
    public sealed class EstadoCuentaRepository : GenericRepository<EstadoCuentum>, IEstadoCuentaRepository
    {
        public EstadoCuentaRepository(TestDBContext context) : base(context)
        {
        }

        public IEnumerable<EstadoCuentum> GetMovimientosPorFechaCliente(string identificacion, DateTime fechaInicial, DateTime fechaFinal)
        {
            return TestDBContext.EstadoCuenta.Where(a => a.Identificacion == identificacion && a.Fecha >= fechaInicial && a.Fecha <= fechaFinal);
        }


        public TestDBContext TestDBContext
        {
            get { return Context as TestDBContext; }
        }
    }
}
