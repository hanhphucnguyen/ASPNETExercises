﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
namespace ASPNetExercises.Models
{
    public class AppDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public virtual DbSet<MenuItem> MenuItems { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Tray> Trays { get; set; }
        public virtual DbSet<TrayItem> TrayItems { get; set; }
    }
}