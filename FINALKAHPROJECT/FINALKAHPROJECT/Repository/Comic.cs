using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FINALKAHPROJECT.Models;
using FINALKAHPROJECT.Migrations;
using System.Data;

namespace FINALKAHPROJECT.Repository
{
    public class Comic
    {
        private ApplicationDbContext _context;
        public Comic(ApplicationDbContext context)
        {
            _context = context;
        }
       
    }
}
