namespace Generator.Entity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelGenerdor : DbContext
    {
        public ModelGenerdor()
            : base("name=ModelGenerdor")
        {
        }

        public virtual DbSet<Categoria> Categoria { get; set; }
        public virtual DbSet<Producto> Producto { get; set; }
        public virtual DbSet<ProductoCategoria> ProductoCategoria { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>()
                .HasMany(e => e.ProductoCategoria)
                .WithRequired(e => e.Categoria)
                .HasForeignKey(e => e.IdCategoria)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Producto>()
                .Property(e => e.Precio)
                .HasPrecision(18, 0);

            modelBuilder.Entity<Producto>()
                .HasMany(e => e.ProductoCategoria)
                .WithRequired(e => e.Producto)
                .HasForeignKey(e => e.IdProducto)
                .WillCascadeOnDelete(false);
        }
    }
}
