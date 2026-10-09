using System;

namespace GestorIncidenciasTI.Models
{
    public class Incidencia
    {
        public int Id { get; set; }

        public string Titulo { get; set; }

        public string Categoria { get; set; }

        public string Impacto { get; set; }

        public string Urgencia { get; set; }

        public string Descripcion { get; set; }

        public DateTime FechaRegistro { get; set; }
    }
}