using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace BusinessLayer.Repositories.Interfaces
{
    public interface ICuentaRepository: IGenericRepository<Cuenta>
    {
        Cuenta Get(string numeroCuenta);
    }
}
