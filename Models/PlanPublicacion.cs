using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousesPeru.Models
{
    public class PlanPublicacion
    {
        public int Id { get; set; }
        public int PlanId { get; set; }
        public int PublicacionId { get; set; }

        public Publicacion Publicacion { get; set; }

    }
}
