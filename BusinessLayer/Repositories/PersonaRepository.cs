using System;
using System.Collections.Generic;
using System.Text;
using DataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using BusinessLayer.Repositories.Interfaces;

namespace BusinessLayer.Repositories
{
    public sealed class PersonaRepository: GenericRepository<Persona>, IPersonaRepository
    {
        public PersonaRepository(TestDBContext context) : base(context)
        {
        }

        public Persona Get(string identifcacion)
        {
            return (Persona)TestDBContext.Personas.Where(a => a.Identificacion == identifcacion).FirstOrDefault();
        }


        public TestDBContext TestDBContext
        {
            get { return Context as TestDBContext; }
        }
    }
}
