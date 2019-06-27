using BangServer.Core.Entity;
using BangServer.Core.Entity.Models;
using BangServer.Core.Interfaces;
using System;
using System.Collections.Generic;

namespace BangServer.Data
{
    public class AccountRepository : RepositoryBase<Account>, IAccountRepository
    {
        public AccountRepository(RepositoryContext repositoryContext)
            : base(repositoryContext)
        {
        }

        public IEnumerable<Account> AccountsByOwner(Guid ownerId)
        {
            return FindByCondition(a => a.OwnerId.Equals(ownerId));
        }
    }
}
