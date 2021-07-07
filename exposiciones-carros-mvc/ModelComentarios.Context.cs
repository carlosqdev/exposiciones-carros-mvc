﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace exposiciones_carros_mvc
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class comentariosEntities : DbContext
    {
        public comentariosEntities()
            : base("name=comentariosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comentarios> Comentarios { get; set; }
    
        public virtual int InsertarMensaje(string nombre, string mensaje)
        {
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var mensajeParameter = mensaje != null ?
                new ObjectParameter("Mensaje", mensaje) :
                new ObjectParameter("Mensaje", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertarMensaje", nombreParameter, mensajeParameter);
        }
    
        public virtual ObjectResult<MostrarMensajes_Result> MostrarMensajes(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("Id", id) :
                new ObjectParameter("Id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<MostrarMensajes_Result>("MostrarMensajes", idParameter);
        }
    }
}
