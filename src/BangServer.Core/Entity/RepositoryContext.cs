﻿using BangServer.Core.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace BangServer.Core.Entity
{
    public class RepositoryContext: DbContext
    {
        public RepositoryContext(DbContextOptions options)
            :base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }
    }
}
