using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace FrankyMaslimAPI.Models
{
    public partial class FrankyMaslimContext : DbContext
    {
        public FrankyMaslimContext()
        {
        }

        public FrankyMaslimContext(DbContextOptions<FrankyMaslimContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<ExperienceDescriptions> ExperienceDescriptions { get; set; }
        public virtual DbSet<Experiences> Experiences { get; set; }
        public virtual DbSet<JobTitles> JobTitles { get; set; }
        public virtual DbSet<Main> Main { get; set; }
        public virtual DbSet<ProjectDescriptions> ProjectDescriptions { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<Qualifications> Qualifications { get; set; }
        public virtual DbSet<TechnicalSkillCategories> TechnicalSkillCategories { get; set; }
        public virtual DbSet<TechnicalSkills> TechnicalSkills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:azpracticesqlserver.database.windows.net,1433;Initial Catalog=FrankyMaslim;Persist Security Info=False;User ID=fmaslim;Password=AzpracticeVM1;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Education>(entity =>
            {
                entity.Property(e => e.EducationId).HasColumnName("EducationID");

                entity.Property(e => e.CollegeName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EducationName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Notes)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ExperienceDescriptions>(entity =>
            {
                entity.HasKey(e => e.ExperienceDescriptionId);

                entity.Property(e => e.ExperienceDescriptionId).HasColumnName("ExperienceDescriptionID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ExperienceId).HasColumnName("ExperienceID");

                entity.Property(e => e.SortOrder).HasMaxLength(10);

                entity.HasOne(d => d.Experience)
                    .WithMany(p => p.ExperienceDescriptions)
                    .HasForeignKey(d => d.ExperienceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Experienc__Exper__778AC167");
            });

            modelBuilder.Entity<Experiences>(entity =>
            {
                entity.HasKey(e => e.ExperienceId);

                entity.Property(e => e.ExperienceId).HasColumnName("ExperienceID");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.JobTitleId).HasColumnName("JobTitleID");

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkplaceName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.Experiences)
                    .HasForeignKey(d => d.JobTitleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Experienc__JobTi__74AE54BC");
            });

            modelBuilder.Entity<JobTitles>(entity =>
            {
                entity.HasKey(e => e.JobTitleId);

                entity.HasIndex(e => e.JobTitleName)
                    .HasName("UQ__tmp_ms_x__5182B52C4A3B01CF")
                    .IsUnique();

                entity.Property(e => e.JobTitleId).HasColumnName("JobTitleID");

                entity.Property(e => e.JobTitleName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Main>(entity =>
            {
                entity.Property(e => e.MainId).HasColumnName("MainID");

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Objective).IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.State)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ZipCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);			
            });
			//modelBuilder.Entity<Main>()
			//					.HasMany(q => q.Qualifications)
			//					.WithOne(m => m.Main).IsRequired();

            modelBuilder.Entity<ProjectDescriptions>(entity =>
            {
                entity.HasKey(e => e.ProjectDescriptionId);

                entity.Property(e => e.ProjectDescriptionId).HasColumnName("ProjectDescriptionID");

                entity.Property(e => e.ProjectDescriptionName)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectDescriptions)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProjectDe__Proje__03F0984C");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.EndDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Url)
                    .HasColumnName("URL")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Qualifications>(entity =>
            {
                entity.HasKey(e => e.QualificationId);

                entity.Property(e => e.QualificationId).HasColumnName("QualificationID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.MainId).HasColumnName("MainID");

                entity.HasOne(d => d.Main)
                    .WithMany(p => p.Qualifications)
                    .HasForeignKey(d => d.MainId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Qualifica__MainI__6D0D32F4");
            });
			//modelBuilder.Entity<Qualifications>()
			//					.HasOne(m => m.Main)
			//					.WithMany(q => q.Qualifications)
			//					.HasForeignKey(m => m.MainId);

            modelBuilder.Entity<TechnicalSkillCategories>(entity =>
            {
                entity.HasKey(e => e.TechnicalSkillCategoryId);

                entity.Property(e => e.TechnicalSkillCategoryId).HasColumnName("TechnicalSkillCategoryID");

                entity.Property(e => e.TechnicalSkillCategoryName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechnicalSkills>(entity =>
            {
                entity.HasKey(e => e.TechnicalSkillId);

                entity.Property(e => e.TechnicalSkillId).HasColumnName("TechnicalSkillID");

                entity.Property(e => e.TechnicalSkillCategoryId).HasColumnName("TechnicalSkillCategoryID");

                entity.Property(e => e.TechnicalSkillName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.TechnicalSkillCategory)
                    .WithMany(p => p.TechnicalSkills)
                    .HasForeignKey(d => d.TechnicalSkillCategoryId)
                    .HasConstraintName("FK__Technical__Techn__02FC7413");
            });
        }
    }
}
