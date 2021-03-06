﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocationDataAccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class LocationDBEntities : DbContext
    {
        public LocationDBEntities()
            : base("name=LocationDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Location> Location { get; set; }
    
        public virtual ObjectResult<SPGetAllLocations_Result> SPGetAllLocations()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SPGetAllLocations_Result>("SPGetAllLocations");
        }
    
        public virtual ObjectResult<spGetAllLocations1_Result> spGetAllLocations1()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllLocations1_Result>("spGetAllLocations1");
        }
    
        public virtual ObjectResult<spGetAllLocationsById_Result> spGetAllLocationsById(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<spGetAllLocationsById_Result>("spGetAllLocationsById", idParameter);
        }
    
        public virtual int spInsertLocation(string name, string address, string city, string province)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var provinceParameter = province != null ?
                new ObjectParameter("province", province) :
                new ObjectParameter("province", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spInsertLocation", nameParameter, addressParameter, cityParameter, provinceParameter);
        }
    
        public virtual int spUpdateLocation(Nullable<int> id, string name, string address, string city, string province)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("city", city) :
                new ObjectParameter("city", typeof(string));
    
            var provinceParameter = province != null ?
                new ObjectParameter("province", province) :
                new ObjectParameter("province", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("spUpdateLocation", idParameter, nameParameter, addressParameter, cityParameter, provinceParameter);
        }
    }
}
