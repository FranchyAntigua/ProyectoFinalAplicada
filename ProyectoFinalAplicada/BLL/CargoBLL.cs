using ProyectoFinalAplicada.DAL;
using ProyectoFinalAplicada.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinalAplicada.BLL
{
   public class CargoBLL
    {
        public static bool Guardar(Cargos cargos)
        {
            bool estado = false;
            try
            {
                Contexto context = new Contexto();
                context.Cargos.Add(cargos);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static bool Editar(Cargos cargos)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(cargos).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                Cargos cargos = contexto.Cargos.Find(id);

                contexto.Cargos.Remove(cargos);

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public static Cargos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Cargos cargos = new Cargos();
            try
            {
                cargos = contexto.Cargos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return cargos;
        }

        public static List<Cargos> GetList(Expression<Func<Cargos, bool>> expression)
        {
            List<Cargos> cargos = new List<Cargos>();
            Contexto contexto = new Contexto();

            try
            {
                cargos = contexto.Cargos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }

            return cargos;
        }
    }
}
