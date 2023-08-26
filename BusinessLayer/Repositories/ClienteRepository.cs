using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DataAccess.Models;
using BusinessLayer.Repositories.Interfaces;

namespace BusinessLayer.Repositories
{
    public sealed class ClienteRepository: GenericRepository<Cliente>, IClienteRepository
    {
        public ClienteRepository(TestDBContext context) : base(context)
        {
        }

        public Cliente Get(string identifcacion)
        {
            return (Cliente)TestDBContext.Clientes.Where(a => a.Identificacion == identifcacion).FirstOrDefault();
        }


        public TestDBContext TestDBContext
        {
            get { return Context as TestDBContext; }
        }
    }
}
