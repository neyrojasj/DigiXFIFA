﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MY_SOCCER_CONEXION : DbContext
    {
        public MY_SOCCER_CONEXION()
            : base("name=MY_SOCCER_CONEXION")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCION> ACCION { get; set; }
        public virtual DbSet<ADMINISTRADOR> ADMINISTRADOR { get; set; }
        public virtual DbSet<ARDUINO> ARDUINO { get; set; }
        public virtual DbSet<COMENTARIO> COMENTARIO { get; set; }
        public virtual DbSet<COMENTARIO_ESTADISTICO> COMENTARIO_ESTADISTICO { get; set; }
        public virtual DbSet<COMENTARIO_ESTADISTICO_X_JUGADOR> COMENTARIO_ESTADISTICO_X_JUGADOR { get; set; }
        public virtual DbSet<COMENTARIO_LIBRE> COMENTARIO_LIBRE { get; set; }
        public virtual DbSet<CUENTA> CUENTA { get; set; }
        public virtual DbSet<EQUIPO> EQUIPO { get; set; }
        public virtual DbSet<FANATICO> FANATICO { get; set; }
        public virtual DbSet<FOTO_EQUIPO> FOTO_EQUIPO { get; set; }
        public virtual DbSet<JUGADOR> JUGADOR { get; set; }
        public virtual DbSet<NARRADOR> NARRADOR { get; set; }
        public virtual DbSet<PAIS> PAIS { get; set; }
        public virtual DbSet<PARTIDO> PARTIDO { get; set; }
        public virtual DbSet<RECHAZADO> RECHAZADO { get; set; }
        public virtual DbSet<RESULTADO_PARTIDO> RESULTADO_PARTIDO { get; set; }
        public virtual DbSet<SEDE> SEDE { get; set; }
        public virtual DbSet<TITULAR> TITULAR { get; set; }
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<TORNEO> TORNEO { get; set; }
        public virtual DbSet<COMENTARIO_TIEMPO> COMENTARIO_TIEMPO { get; set; }
        public virtual DbSet<JUGADOR_X_EQUIPO> JUGADOR_X_EQUIPO { get; set; }
    }
}
