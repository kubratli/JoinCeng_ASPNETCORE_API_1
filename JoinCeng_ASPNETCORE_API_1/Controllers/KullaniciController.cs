using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JoinCeng_ASPNETCORE_API_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace JoinCeng_ASPNETCORE_API_1.Controllers
{
    [Route("api/[controller]")]
    public class KullaniciController : Controller
    {
        private readonly KullaniciContext _context;

        public KullaniciController(KullaniciContext context)
        {
            _context = context;

            if (_context.Kullanicis.Count() == 0)
            {
                _context.Kullanicis.Add(new Kullanici { KullaniciID = 1, KullaniciAdi = "Kübra ATLI", Email = "k@gmail.com" });
                _context.Kullanicis.Add(new Kullanici { KullaniciID = 2, KullaniciAdi = "Büşra Sağlam", Email = "b@gmail.com"  });
                _context.Kullanicis.Add(new Kullanici { KullaniciID = 3, KullaniciAdi = "Sevgi Hayat", Email = "s@gmail.com" }); 

                _context.SaveChanges();
            }
        }

        [HttpGet]
        public IEnumerable<Kullanici> Get()
        {
            return _context.Kullanicis.ToList();
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var kullanici = _context.Kullanicis.FirstOrDefault(t => t.KullaniciID == id);
            if (kullanici == null)
            {
                return NotFound();
            }
            return new ObjectResult(kullanici);
        }

        [HttpPost]
        public void Post([FromBody]string value)
        { 
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        { 
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        { 
        }
    }
}