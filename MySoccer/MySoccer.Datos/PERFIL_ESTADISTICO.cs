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
    
    public partial class PERFIL_ESTADISTICO
    {
        public int PK_FK_Pasaporte_XFIFA { get; set; }
        public int PK_FK_Equipo { get; set; }
        public int PK_FK_Torneo { get; set; }
        public int Juegos_Ganados { get; set; }
        public int Juegos_Perdidos { get; set; }
        public int Juegos_Empatados { get; set; }
        public int Goles { get; set; }
        public int Tiros_Marco { get; set; }
        public int Asistencias { get; set; }
        public int Recuperaciones { get; set; }
        public int Tarjetas_Amarillas { get; set; }
        public int Tarjetas_Rojas { get; set; }
        public int Penales_Detenidos { get; set; }
        public int Penales_Cometidos { get; set; }
        public int Ramates_Salvados { get; set; }
        public double Nota_XFIFA { get; set; }
        public int Ano { get; set; }
    
        public virtual EQUIPO EQUIPO { get; set; }
        public virtual JUGADOR JUGADOR { get; set; }
        public virtual TORNEO TORNEO { get; set; }
    }
}
