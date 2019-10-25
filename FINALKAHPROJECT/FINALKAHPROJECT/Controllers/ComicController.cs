using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FINALKAHPROJECT.Models;

namespace FINALKAHPROJECT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComicController 
    {
        private ApplicationDbContext _context;
        public ComicController(ApplicationDbContext context)
        {
            _context = context;
           //return View();
        }
     
        [HttpGet]
        public IEnumerable<Comic> GetComics()
        {
            return _context.comic.ToList();
        }


    }
}