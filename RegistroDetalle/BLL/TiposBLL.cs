using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace RegistroDetalle.BLL
{
    class TiposBLL
    {
        public static bool Guardar(Tipos Tipos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Tipos.Add(Tipos) != null)
                {
                    paso = db.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;

            }
            finally
            {
                db.Dispose();
            }

            return paso;
        }
        public static bool Modificar(Tipos Tipo)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(Tipo).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            { throw; }

            finally
            { db.Dispose(); }

            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Tipos.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;

                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return paso;
        }
        public static Tipos Buscar(int id)
        {
            Contexto db = new Contexto();
            Tipos Tipo = new Tipos();
            try
            {
                Tipo = db.Tipos.Find(id);
                db.Dispose();
            }
            catch (Exception)
            { throw; }

            return Tipo;
        }
        public static List<Tipos> GetList(Expression<Func<Tipos, bool>> expression)
        {
            List<Tipos> tipos = new List<Tipos>();
            Contexto contexto = new Contexto();

            try
            {
                tipos = contexto.Tipos.Where(expression).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return tipos;
        }
    }
}
    
