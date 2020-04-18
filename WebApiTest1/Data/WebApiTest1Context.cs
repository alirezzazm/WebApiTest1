using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApiTest1.Models;

namespace WebApiTest1.Data
{
    public class WebApiTest1Context : DbContext
    {
        public WebApiTest1Context (DbContextOptions<WebApiTest1Context> options)
            : base(options)
        {
        }

        public DbSet<WebApiTest1.Models.DietApi> DietApi { get; set; }
    }
}
