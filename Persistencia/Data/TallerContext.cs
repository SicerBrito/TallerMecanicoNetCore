using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Persistencia.Data;
    public class TallerContext : DbContext{
        public TallerContext(DbContextOptions<TallerContext> options) : base(options){

        }

        




        protected override void OnModelCreating(ModelBuilder modelBuilder){
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
