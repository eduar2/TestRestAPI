using DataAccess.Models;
using System;
using System.Collections.Generic;

namespace BusinessLayer.Services.Interfaces
{
    public interface IMovimientoService
    {
        List<Movimiento> ConsultMovimientos(); 
        bool CreateMovimiento(ref Movimiento movimiento, ref string mensaje);
        bool UpdateMovimiento(ref Movimiento movimiento, ref string mensaje);
        bool DeleteMovimiento(int idMovimiento, ref string mensaje);
        List<EstadoCuentum> ConsultMovimientosPorFechas(DateTime FechaInicio, DateTime FechaFin, string IdentificacionCliente);

        public Movimiento FindMovimiento(int id);
    }
}
