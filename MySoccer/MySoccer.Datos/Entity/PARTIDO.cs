//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySoccer.Datos.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class PARTIDO
    {
        public int PK_Partido { get; set; }
        public System.DateTime Fecha { get; set; }
        public System.TimeSpan Hora { get; set; }
        public string Fase { get; set; }
        public int FK_Equipo_1 { get; set; }
        public int FK_Equipo_2 { get; set; }
        public int FK_Sede { get; set; }
        public int Estado { get; set; }
        public int FK_Torneo { get; set; }
    }
}
