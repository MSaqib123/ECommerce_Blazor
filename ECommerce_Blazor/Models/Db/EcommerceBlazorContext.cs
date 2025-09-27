using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ECommerce_Blazor.Models.Db;

public partial class EcommerceBlazorContext : DbContext
{
    public EcommerceBlazorContext()
    {
    }

    public EcommerceBlazorContext(DbContextOptions<EcommerceBlazorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Menu> Menus { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=SAQIB\\MSSQLSERVER01; Database=ECommerce_Blazor;Trusted_Connection=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
