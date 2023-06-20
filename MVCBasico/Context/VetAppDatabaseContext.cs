using Microsoft.EntityFrameworkCore;
using MVCBasico.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasico.Context
{
    public class VetAppDatabaseContext : DbContext
    {
        public VetAppDatabaseContext(DbContextOptions<VetAppDatabaseContext> options): base(options)
        {
        }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Veterinario> Veterinarios { get; set; }
        public DbSet<Consulta> Consultas { get; set; }


    }

}
