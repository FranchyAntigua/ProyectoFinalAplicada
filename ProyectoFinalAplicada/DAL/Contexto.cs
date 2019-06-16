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
        public DbSet<Cargos> Cargos { get; set; }
        public DbSet<Clientes> clientes { get; set; }
        public DbSet<Productos> producto { get; set; }
        public DbSet<EntradaProductos> entrada { get; set; }
        //  public DbSet<Fibonacci> Fibonacci { get; set; }
        public Contexto() : base("ConStr")
        {

        }
    }
}

  

