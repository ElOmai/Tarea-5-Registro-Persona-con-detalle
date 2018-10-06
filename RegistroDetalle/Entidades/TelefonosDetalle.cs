using System;

namespace RegistroDetalle.Entidades
{
    internal class TelefonosDetalle
    {
        [key]
        public int Id { get; set; }
        public int PersonaId { get; set; }
        public string TipoTelefono { get; set; }
        public string Telefono { get; set; }

        public TelefonosDetalle(int id, int personaId, string tipoTelefono, string telefono)
        {
            Id = 0;
            PersonaId = 0;
            TipoTelefono = string.Empty;
            Telefono = string.Empty;
        }
    }
}