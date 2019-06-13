using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using DataAccessLayer.Model;

namespace DataAccessLayer
{
    public partial class RestaurantManagerContext : DbContext
    {
        public RestaurantManagerContext()
        {
        }

        public RestaurantManagerContext(DbContextOptions<RestaurantManagerContext> options)
            : base(options)
        {
        }

        public virtual DbSet<LocalWorkers> LocalWorkers { get; set; }
        public virtual DbSet<Locals> Locals { get; set; }
        public virtual DbSet<Logger> Logger { get; set; }
        public virtual DbSet<MealType> MealType { get; set; }
        public virtual DbSet<Meals> Meals { get; set; }
        public virtual DbSet<MealsCompositions> MealsCompositions { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<RestaurantMenu> RestaurantMenu { get; set; }
        public virtual DbSet<Suppliers> Suppliers { get; set; }
        public virtual DbSet<SuppliersPerLocal> SuppliersPerLocal { get; set; }
        public virtual DbSet<SuppliersPerProducts> SuppliersPerProducts { get; set; }
        public virtual DbSet<Workers> Workers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:restaurantmanagerprojectserver.database.windows.net,1433;Database=RestaurantManagerDataBase;User ID=Michal;Password='Qwerty!2';Encrypt=true;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<LocalWorkers>(entity =>
            {
                entity.HasOne(d => d.LocalsNavigation)
                    .WithMany(p => p.LocalWorkers)
                    .HasForeignKey(d => d.Locals)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LocalWorkers_fk1");

                entity.HasOne(d => d.WorkersNavigation)
                    .WithMany(p => p.LocalWorkers)
                    .HasForeignKey(d => d.Workers)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("LocalWorkers_fk0");
            });

            modelBuilder.Entity<Locals>(entity =>
            {
                entity.HasKey(e => e.LocalId)
                    .HasName("PK__Locals__499359DB3AB2B2CF");

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Street).IsUnicode(false);
            });

            modelBuilder.Entity<Logger>(entity =>
            {
                entity.Property(e => e.OperationDescription).IsUnicode(false);
            });

            modelBuilder.Entity<MealType>(entity =>
            {
                entity.HasKey(e => e.MealId)
                    .HasName("PK__MealType__ACF6A65DDBA1CD7B");

                entity.Property(e => e.Type).IsUnicode(false);
            });

            modelBuilder.Entity<Meals>(entity =>
            {
                entity.HasKey(e => e.MealId)
                    .HasName("PK__Meals__ACF6A65D734E75A3");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<MealsCompositions>(entity =>
            {
                entity.HasOne(d => d.MealNavigation)
                    .WithMany(p => p.MealsCompositions)
                    .HasForeignKey(d => d.Meal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MealsCompositions_fk0");

                entity.HasOne(d => d.MealTypeNavigation)
                    .WithMany(p => p.MealsCompositions)
                    .HasForeignKey(d => d.MealType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MealsCompositions_fk2");

                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.MealsCompositions)
                    .HasForeignKey(d => d.Product)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("MealsCompositions_fk1");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(e => e.ProductId)
                    .HasName("PK__Products__B40CC6EDC510BA38");

                entity.Property(e => e.Name).IsUnicode(false);
            });

            modelBuilder.Entity<RestaurantMenu>(entity =>
            {
                entity.HasOne(d => d.LocalNavigation)
                    .WithMany(p => p.RestaurantMenu)
                    .HasForeignKey(d => d.Local)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RestaurantMenu_fk0");

                entity.HasOne(d => d.MealNavigation)
                    .WithMany(p => p.RestaurantMenu)
                    .HasForeignKey(d => d.Meal)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("RestaurantMenu_fk1");
            });

            modelBuilder.Entity<Suppliers>(entity =>
            {
                entity.HasKey(e => e.SupplierId)
                    .HasName("PK__Supplier__4BE66694CE57479F");

                entity.Property(e => e.City).IsUnicode(false);

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Street).IsUnicode(false);
            });

            modelBuilder.Entity<SuppliersPerLocal>(entity =>
            {
                entity.HasOne(d => d.LocalNavigation)
                    .WithMany(p => p.SuppliersPerLocal)
                    .HasForeignKey(d => d.Local)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SuppliersPerLocal_fk1");

                entity.HasOne(d => d.SupplierNavigation)
                    .WithMany(p => p.SuppliersPerLocal)
                    .HasForeignKey(d => d.Supplier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SuppliersPerLocal_fk0");
            });

            modelBuilder.Entity<SuppliersPerProducts>(entity =>
            {
                entity.HasOne(d => d.ProductNavigation)
                    .WithMany(p => p.SuppliersPerProducts)
                    .HasForeignKey(d => d.Product)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SuppliersPerProducts_fk1");

                entity.HasOne(d => d.SupplierNavigation)
                    .WithMany(p => p.SuppliersPerProducts)
                    .HasForeignKey(d => d.Supplier)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("SuppliersPerProducts_fk0");
            });

            modelBuilder.Entity<Workers>(entity =>
            {
                entity.HasKey(e => e.WorkerId)
                    .HasName("PK__Workers__077C88061EA8E4B2");

                entity.Property(e => e.Name).IsUnicode(false);

                entity.Property(e => e.Pesel).IsUnicode(false);

                entity.Property(e => e.Surname).IsUnicode(false);
            });
        }
    }
}
