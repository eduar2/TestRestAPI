using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;

namespace BusinessLayer.Repositories.Interfaces
{
    public interface IPersonaRepository: IGenericRepository<Persona>
    {

        Persona Get(string identificacion);
    }
}
