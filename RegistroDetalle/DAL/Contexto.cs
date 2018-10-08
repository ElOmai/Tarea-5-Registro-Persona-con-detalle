using RegistroDetalle.Entidades;
using System.Data.Entity;

namespace RegistroDetalle.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Persona> Personas { get; set; }
        public DbSet<TelefonosDetalle> Telefonos { get; set; }
        public DbSet<Tipos> Tipos { get; set; }
        public Contexto() : base("ConStr")
        { }
    };
}
