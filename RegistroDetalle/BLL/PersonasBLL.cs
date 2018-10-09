using System;
using RegistroDetalle.DAL;
using RegistroDetalle.Entidades;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace RegistroDetalle.BLL
{
    public class PersonasBLL
    {
        public static bool Guardar(Persona persona)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.Personas.Add(persona) != null)
                {
                    db.SaveChanges();
                    paso = true;
                }

                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
        public static bool Modificar(Persona persona)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var Anterior = db.Personas.Find(persona.PersonaId);
                foreach(var item in Anterior.Telefonos)
                {
                    if (!persona.Telefonos.Exists(d => d.Id == item.Id))
                        db.Entry(item).State = EntityState.Deleted;
                    else
                        db.Entry(item).State = EntityState.Modified;
                }
                db.Entry(persona).State = EntityState.Modified;
                paso = (db.SaveChanges() > 0);
                db.Dispose();
            }
            catch (Exception)
            {throw;}

            finally
            {db.Dispose();}

            return paso;
        }
        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.Personas.Find(id);
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
        public static Persona Buscar(int id)
        {
            Contexto db = new Contexto();
            Persona persona = new Persona();
            try
            {
                persona = db.Personas.Find(id);
                persona.Telefonos.Count();
            }
            catch (Exception)
            {throw;}

            finally
            {db.Dispose();}

            return persona;
        }
        public static List<Persona> GetList(Expression<Func<Persona, bool>> persona)
        {
            List<Persona> personaes = new List<Persona>();
            Contexto db = new Contexto();
            try
            {
                personaes = db.Personas.Where(persona).ToList();
                db.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return personaes;
        }
    }
}