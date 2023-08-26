using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace BusinessLayer.Repositories.Interfaces
{
    public interface IClienteRepository: IGenericRepository<Cliente>
    {

        Cliente Get(string identificacion);
        

    }
}
