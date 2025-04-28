using ElectionBoard.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace ElectionBoard.Persistence;

public class ElectionDbContext(DbContextOptions<ElectionDbContext> options)
    : DbContext(options)
{
    public const string ConnectionStringName = "SvcElectionContext";
    
    public DbSet<State> States { get; set; }
    public DbSet<CondidateVote> CondidateVotes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.UseAsyncSeeding(async (context,_,cancellationToken) =>
    {
        context.Database.EnsureCreated();
        var states = context.Set<State>();
        if (!await states.AnyAsync(cancellationToken))
        {
            states.AddRange(ElectionDbContextSeedData.GetStates()); 
        }
        
    });

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ConfigureCandidateVoteTable(modelBuilder);
        ConfigureStateTable(modelBuilder);
    }
    private static void ConfigureCandidateVoteTable(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CondidateVote>(builder =>
        {
            builder.HasKey(z => new { z.ElectionCycle, z.FipsCode, z.Code });

            builder.Property(z => z.Name)
                .HasMaxLength(100)
                .IsRequired();
            builder.Property(z => z.Code)
                .HasMaxLength(10)
                .IsRequired();

            builder.Property(z => z.ElectionCycle)
                .IsRequired();
            
            builder.Property(z => z.FipsCode)
                .HasMaxLength(3)
                .IsRequired();
        });
    }
    
    private static void ConfigureStateTable(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<State>(builder =>
        {
            builder.HasKey(z => z.FipsCode);

            builder.Property(z => z.Name)
                .HasMaxLength(50)
                .IsRequired();
            
            builder.Property(z => z.FipsCode)
                .HasMaxLength(3)
                .IsRequired();
        });
    }
} 