using Microsoft.EntityFrameworkCore;
using SistemaAcademia.Models;

namespace SistemaAcademia.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
