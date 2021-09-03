using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace TutoriasEF.Models
{
    class TutoriasContext : DbContext
    {
        public DbSet<Credencial> Credenciales { get; set; }
        public DbSet<Profesional> Profesionales { get; set; }
        public DbSet<TutoriaPersonalizada> TutoriasPersonalizadas { get; set; }
        public DbSet<TutoriaHorario> HorariosTutorias { get; set; }
        public DbSet<TutoriaInscrita> TutoriasInscritas { get; set;}
        public DbSet<HorarioCurso> HorariosCursos { get; set; }
        public DbSet<CursoInscrito> CursosInscritos { get; set; }

        public string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=TutoriasDB;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer(connectionString);
    }
}
