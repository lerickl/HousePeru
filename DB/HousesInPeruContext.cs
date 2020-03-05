
//using HousesPeru.DB.Maps;
using HousesPeru.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;
//using DbContext = System.Data.Entity.DbContext;
//using DbContext = Microsoft.EntityFrameworkCore.DbContext;

namespace HousesPeru.DB
{
    public class HousesInPeruContext: DbContext
    {
        public HousesInPeruContext(DbContextOptions<HousesInPeruContext> options)
           : base(options)
        {
          
        }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<Publicacion> Publicacions { get; set; }
        public virtual DbSet<PlanPublicacion> PlanPublicacions { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<InmuebleTipo> InmuebleTipos { get; set; }
        public virtual DbSet<Inmueble> Inmuebles { get; set; }
        public virtual DbSet<Imagen> Imagens { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("Data Source=HousesinPeru");

        //}
        //public HousesInPeruContext()
        //{
        //    Database.SetInitializer<HousesInPeruContext>(null);
        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
       
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Configurations.Add(new UsuarioMap());
            //modelBuilder.Configurations.Add(new PublicacionMap());
            //modelBuilder.Configurations.Add(new PlanPublicacionMap());
            //modelBuilder.Configurations.Add(new PlanMap());
            //modelBuilder.Configurations.Add(new InmuebleTipoMap());
            //modelBuilder.Configurations.Add(new InmuebleMap());
            //modelBuilder.Configurations.Add(new ImagenMap());

        }
        

    }
}
