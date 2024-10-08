﻿

using Microsoft.EntityFrameworkCore;
using ReserveiAPI.Contexts.Builders;
using ReserveiAPI.Objects.Models.Entities;

namespace ReserveiAPI.Contexts
{
    public class AppDBContext : DbContext
    {
        // Mapeamento Relacional dos Objetos no Banco de Dados 
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        // Conjunto: Usuário
        public DbSet<UserModel> Users { get; set; }

        //Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Entidades de Usuário:
            UserBuilder.Build(modelBuilder);
        }
    }
}
