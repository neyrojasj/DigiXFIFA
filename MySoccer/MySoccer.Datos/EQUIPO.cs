//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MySoccer.Datos
{
    using System;
    using System.Collections.Generic;
    
    public partial class EQUIPO
    {
        public EQUIPO()
        {
            this.COMENTARIO_ESTADISTICO = new HashSet<COMENTARIO_ESTADISTICO>();
            this.PARTIDO_REGISTRADO = new HashSet<PARTIDO_REGISTRADO>();
            this.PARTIDO_REGISTRADO1 = new HashSet<PARTIDO_REGISTRADO>();
            this.FANATICO = new HashSet<FANATICO>();
            this.JUGADOR = new HashSet<JUGADOR>();
        }
    
        public int PK_Equipo { get; set; }
        public string Nombre_Federacion { get; set; }
        public string Foto { get; set; }
        public System.DateTime Fecha_Asociacion_XFIFA { get; set; }
        public int FK_Pais { get; set; }
    
        public virtual ICollection<COMENTARIO_ESTADISTICO> COMENTARIO_ESTADISTICO { get; set; }
        public virtual ICollection<PARTIDO_REGISTRADO> PARTIDO_REGISTRADO { get; set; }
        public virtual ICollection<PARTIDO_REGISTRADO> PARTIDO_REGISTRADO1 { get; set; }
        public virtual ICollection<FANATICO> FANATICO { get; set; }
        public virtual ICollection<JUGADOR> JUGADOR { get; set; }
    }
}
