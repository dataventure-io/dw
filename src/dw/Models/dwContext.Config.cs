using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dw.Models
{
    public partial class dwContext : DbContext
    {
     

        public virtual DbSet<Config> Config { get; set; }
        public virtual DbSet<ConfigParam> ConfigParam { get; set; }

               protected  void OnModelCreatingConfig(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Config>(entity =>
            {
                entity.ToTable("config");

                entity.Property(e => e.ConfigId).HasColumnName("config_id");

                entity.Property(e => e.ConfigName)
                    .IsRequired()
                    .HasColumnName("config_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConfigType)
                    .IsRequired()
                    .HasColumnName("config_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConfigParam>(entity =>
            {
                entity.ToTable("config_param");

                entity.Property(e => e.ConfigParamId).HasColumnName("config_param_id");

                entity.Property(e => e.ConfigId).HasColumnName("config_id");

                entity.Property(e => e.ParamName)
                    .IsRequired()
                    .HasColumnName("param_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ParamValue)
                    .IsRequired()
                    .HasColumnName("param_value")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.HasOne(d => d.Config)
                    .WithMany(p => p.ConfigParam)
                    .HasForeignKey(d => d.ConfigId)
                    .HasConstraintName("fk_config_param_config");
            });

           
        }

        
    }
}
