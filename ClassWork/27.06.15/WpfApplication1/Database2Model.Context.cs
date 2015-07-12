﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Database2Entities : DbContext
    {
        public Database2Entities()
            : base("name=Database2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Game> Games { get; set; }
        public virtual DbSet<League> Leagues { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
    
        public virtual int InitData(Nullable<bool> delete, ObjectParameter deleted)
        {
            var deleteParameter = delete.HasValue ?
                new ObjectParameter("delete", delete) :
                new ObjectParameter("delete", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InitData", deleteParameter, deleted);
        }
    }
}
