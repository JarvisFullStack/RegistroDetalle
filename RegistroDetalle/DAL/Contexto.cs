using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistroDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Personas> Personas;
        public DbSet<TelefonosDetalle> TelefonosDetalle;

        public Contexto () : base("ConStr")
        {

        }
    }
}
