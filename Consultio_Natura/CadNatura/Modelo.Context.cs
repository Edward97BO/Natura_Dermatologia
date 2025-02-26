﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CadNatura
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NaturaEntities : DbContext
    {
        public NaturaEntities()
            : base("name=NaturaEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cita> Cita { get; set; }
        public virtual DbSet<Dermatologo> Dermatologo { get; set; }
        public virtual DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public virtual DbSet<Paciente> Paciente { get; set; }
        public virtual DbSet<Pago> Pago { get; set; }
        public virtual DbSet<Reconsulta> Reconsulta { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    
        public virtual ObjectResult<paCitaListar_Result> paCitaListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paCitaListar_Result>("paCitaListar", parametroParameter);
        }
    
        public virtual ObjectResult<paDermatologoListar_Result> paDermatologoListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paDermatologoListar_Result>("paDermatologoListar", parametroParameter);
        }
    
        public virtual ObjectResult<paHistoriaClinicaListar_Result> paHistoriaClinicaListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paHistoriaClinicaListar_Result>("paHistoriaClinicaListar", parametroParameter);
        }
    
        public virtual ObjectResult<paPacienteListar_Result> paPacienteListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paPacienteListar_Result>("paPacienteListar", parametroParameter);
        }
    
        public virtual ObjectResult<paPagoListar_Result> paPagoListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paPagoListar_Result>("paPagoListar", parametroParameter);
        }
    
        public virtual ObjectResult<paReconsultaListar_Result> paReconsultaListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paReconsultaListar_Result>("paReconsultaListar", parametroParameter);
        }
    
        public virtual ObjectResult<paUsuarioListar_Result> paUsuarioListar(string parametro)
        {
            var parametroParameter = parametro != null ?
                new ObjectParameter("parametro", parametro) :
                new ObjectParameter("parametro", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<paUsuarioListar_Result>("paUsuarioListar", parametroParameter);
        }
    }
}
