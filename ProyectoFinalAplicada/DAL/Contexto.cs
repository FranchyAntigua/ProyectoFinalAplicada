using ProyectoFinalAplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada.DAL
{
    class Contexto :DbContext
    {

        public DbSet<Usuarios> Usuarios { get; set; }
        //  public DbSet<Fibonacci> Fibonacci { get; set; }
        public Contexto() : base("ConStr")
        {

        }
    }
}

  

