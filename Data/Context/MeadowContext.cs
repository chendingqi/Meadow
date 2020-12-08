using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Context
{
    public class MeadowContext : DbContext
    {
        public MeadowContext(DbContextOptions<MeadowContext> options) : base(options) { }
        public DbSet<MenuEntity> MenuEntitys { get; set; }
        public DbSet<RoleEntity> RoleEntitys { get; set; }
        public DbSet<RoleMenuEntity> RoleMenuEntitys { get; set; }
        public DbSet<RoleUsersEntity> RoleUsersEntitys { get; set; }
        public DbSet<UsersEntity> UsersEntitys { get; set; }
    }
}
