using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using BusinessLayer.Repositories.Interfaces;

namespace BusinessLayer.Repositories
{
    public sealed class MovimientoRepository: GenericRepository<Movimiento>, IMovimientoRepository
    {
        public MovimientoRepository(TestDBContext context) : base(context)
        {
        }

        
        public TestDBContext TestDBContext
        {
            get { return Context as TestDBContext; }
        }
    }
}
