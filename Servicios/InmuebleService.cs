using HousesPeru.DB;
using HousesPeru.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousesPeru.Servicios
{
    public interface IInmuebleService
    {
        IEnumerable<Inmueble> GetAll();
    }
    public class InmuebleService : IInmuebleService

    {
        HousesInPeruContext db;
        public InmuebleService(HousesInPeruContext _db) {
            this.db = _db;
        }

        public IEnumerable<Inmueble> GetAll()
        {
            var Inmuebles = db.Inmuebles
                .Where(x=>x.EstaActivo==true)
                .ToList();
            return Inmuebles;
        }
    }


}
