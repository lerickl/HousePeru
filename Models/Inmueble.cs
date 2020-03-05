﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousesPeru.Models
{
    public class Inmueble
    {
        public int InmuebleId { get; set; }
        //public int InmuebleTipoId { get; set; }
        public int UsuarioId { get; set; }
        public string NombreInm { get; set; }
        public string Area { get; set; }
        public string NumHabitaciones { get; set; }
        public string Pisos { get; set; }
        public string Piso { get; set; }
        public string PrecioVentaInm { get; set; }
        public string PrecioAlquilerInm { get; set; }
        public string UbicacionInm { get; set; }
        public DateTime FechaPublic { get; set; }
        public string CiudadInmueble { get; set; }
        public string Descripcion { get; set; }
        public Boolean EstaActivo { get; set; }
        public virtual InmuebleTipo InmuebleTipo { get; set; }
        public virtual Usuario Usuario { get; set; }
        public List<PlanPublicacion> Publicacion { get; set; }
        public List<Imagen> Imagenes { get; set; }


    }
}
