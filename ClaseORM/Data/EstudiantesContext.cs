using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClaseORM.Models;

    public class EstudiantesContext : DbContext
    {
        public EstudiantesContext (DbContextOptions<EstudiantesContext> options)
            : base(options)
        {
        }

        public DbSet<ClaseORM.Models.EstudianteUdla> EstudianteUdla { get; set; } = default!;
    }
