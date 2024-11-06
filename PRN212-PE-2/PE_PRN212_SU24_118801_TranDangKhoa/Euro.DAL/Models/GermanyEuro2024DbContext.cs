﻿using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Euro.DAL.Models;

public partial class GermanyEuro2024DbContext : DbContext
{
    public GermanyEuro2024DbContext()
    {
    }

    public GermanyEuro2024DbContext(DbContextOptions<GermanyEuro2024DbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<FootballPlayer> FootballPlayers { get; set; }

    public virtual DbSet<FootballTeam> FootballTeams { get; set; }

    public virtual DbSet<Uefaaccount> Uefaaccounts { get; set; }

    private string GetConnectionString()
    {
        IConfiguration config = new ConfigurationBuilder()
             .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", true, true)
                    .Build();
        var strConn = config["ConnectionStrings:DefaultConnectionStringDB"];

        return strConn;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlServer(GetConnectionString());

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<FootballPlayer>(entity =>
        {
            entity.HasKey(e => e.PlayerId).HasName("PK__Football__4A4E74A8334EB44B");

            entity.ToTable("FootballPlayer");

            entity.Property(e => e.PlayerId)
                .HasMaxLength(30)
                .HasColumnName("PlayerID");
            entity.Property(e => e.Achievements).HasMaxLength(250);
            entity.Property(e => e.Award).HasMaxLength(250);
            entity.Property(e => e.Birthday).HasColumnType("datetime");
            entity.Property(e => e.FootballTeamId)
                .HasMaxLength(30)
                .HasColumnName("FootballTeamID");
            entity.Property(e => e.OriginCountry).HasMaxLength(100);
            entity.Property(e => e.PlayerName).HasMaxLength(100);

            entity.HasOne(d => d.FootballTeam).WithMany(p => p.FootballPlayers)
                .HasForeignKey(d => d.FootballTeamId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__FootballP__Footb__3C69FB99");
        });

        modelBuilder.Entity<FootballTeam>(entity =>
        {
            entity.HasKey(e => e.FootballTeamId).HasName("PK__Football__B287F27B6AD7F269");

            entity.ToTable("FootballTeam");

            entity.Property(e => e.FootballTeamId)
                .HasMaxLength(30)
                .HasColumnName("FootballTeamID");
            entity.Property(e => e.Country).HasMaxLength(50);
            entity.Property(e => e.ManagerName).HasMaxLength(100);
            entity.Property(e => e.TeamTitle).HasMaxLength(100);
        });

        modelBuilder.Entity<Uefaaccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__UEFAAcco__349DA586281DCAEE");

            entity.ToTable("UEFAAccount");

            entity.HasIndex(e => e.AccountEmail, "UQ__UEFAAcco__FC770D33178D88E5").IsUnique();

            entity.Property(e => e.AccountId)
                .ValueGeneratedNever()
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountDescription).HasMaxLength(240);
            entity.Property(e => e.AccountEmail).HasMaxLength(80);
            entity.Property(e => e.AccountPassword).HasMaxLength(60);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
