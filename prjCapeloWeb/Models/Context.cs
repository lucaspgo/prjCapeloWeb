using Microsoft.EntityFrameworkCore;
using prjCapeloWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace prjCapeloWeb.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions options) : base(options) { }
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Disciplina> Disciplinas { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Professor> Professors { get; set; }
        public DbSet<Sala> Salas { get; set; }
    }
}
