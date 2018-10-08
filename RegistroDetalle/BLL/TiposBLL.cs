using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System;
using System.Data.Entity;
using System.Linq;

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
        public static bool Modificar(Tipos telefono)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                db.Entry(telefono).State = EntityState.Modified;
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
            Tipos telefono = new Tipos();
            try
            {
                telefono = db.Tipos.Find(id);
                db.Dispose();
            }
            catch (Exception)
            { throw; }

            return telefono;
        }
    }
}