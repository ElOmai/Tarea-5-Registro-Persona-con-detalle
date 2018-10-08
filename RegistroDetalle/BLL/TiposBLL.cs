using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System;
using System.Data.Entity;
using System.Linq;

namespace RegistroDetalle.BLL
{
    class TiposBLL
    {
        public static bool Guardar(TelefonosDetalle Telefonos)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Telefonos.Add(Telefonos) != null)
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
        public static bool Modificar(TelefonosDetalle telefono)
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
                var eliminar = db.Telefonos.Find(id);
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
        public static TelefonosDetalle Buscar(int id)
        {
            Contexto db = new Contexto();
            TelefonosDetalle telefono = new TelefonosDetalle();
            try
            {
                telefono = db.Telefonos.Find(id);
                db.Dispose();
            }
            catch (Exception)
            { throw; }

            return telefono;
        }
    }
}