using System.Data.Entity;
using WS.Config;
using WS.Models;

namespace WS.Context
{
    public class click_ponto_context : DbContext
    {
        public click_ponto_context()
            : base("name=contexto")
        {
                
        }
        public virtual DbSet<account> account { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new account_config());
        }
    }
}