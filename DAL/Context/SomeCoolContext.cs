using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Context;

public class SomeCoolContext : DbContext
{
    public DbSet<Answer> Answers { get; set; }
    public DbSet<Interview> Interviews { get; set; }
    public DbSet<Question> Questions { get; set; }
    public DbSet<Result> Results { get; set; }
    public DbSet<Survey> Surveys { get; set; }

    public SomeCoolContext(DbContextOptions<SomeCoolContext> option) : base(option)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Answer>()
            .Property(t => t.Id)
            .UseIdentityAlwaysColumn();

        modelBuilder.Entity<Interview>()
            .Property(t => t.Id)
            .UseIdentityAlwaysColumn();

        modelBuilder.Entity<Question>()
            .Property(t => t.Id)
            .UseIdentityAlwaysColumn();

        modelBuilder.Entity<Result>()
            .Property(t => t.Id)
            .UseIdentityAlwaysColumn();

        modelBuilder.Entity<Survey>()
            .Property(t => t.Id)
            .UseIdentityAlwaysColumn();

        modelBuilder.Entity<Answer>()
            .HasOne(a => a.Question)
            .WithMany(q => q.Answers)
            .HasForeignKey(a => a.QuestionId);

        modelBuilder.Entity<Interview>()
            .HasOne(i => i.CurrentQuestion)
            .WithOne()
            .HasForeignKey<Interview>(i => i.CurrentQuestionId);

        modelBuilder.Entity<Question>()
            .HasOne(i => i.NextQuestion)
            .WithOne()
            .HasForeignKey<Question>(i => i.NextQuestionId);

        modelBuilder.Entity<Survey>()
            .HasMany(i => i.Questions)
            .WithOne(q => q.Survey)
            .HasForeignKey(i => i.SurveyId);

        base.OnModelCreating(modelBuilder);
    }
}