using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace RegistroDetalle.Entidades
{
    public class Tipos
    {
        [Key]
        public int Id { get; set; }
        public string Tipo { get; set; }

        public Tipos()
        {
            Id = 0;
            Tipo = string.Empty;
        }

    }
}
    