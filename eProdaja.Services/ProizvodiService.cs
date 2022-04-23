using eProdaja.Services.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eProdaja.Services
{
    public class ProizvodiService : IProizvodiService
    {
        public eProdajaContext _context { get; set; }
        public ProizvodiService(eProdajaContext context)
        {
            _context = context;
        }
        public List<Proizvodi> ProizvodiList =new List<Proizvodi> { new Proizvodi() { Id = 1, Naziv = "Laptop" }, new Proizvodi() { Id = 2, Naziv = "Miš" } };
        public IEnumerable<Proizvodi> Get()
        {
            var temp = _context.Proizvodis.ToList();
            ProizvodiList.Add(new Proizvodi() { Naziv ="Test01",Id = 0});
            return ProizvodiList;
        }
        public Proizvodi GetById(int id)
        {
            return ProizvodiList.FirstOrDefault(x=>x.Id==id);
        }
    }
}
