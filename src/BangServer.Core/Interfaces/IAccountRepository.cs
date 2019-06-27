using BangServer.Core.Entity.Models;
using System;
using System.Collections.Generic;

namespace BangServer.Core.Interfaces
{
    public interface IAccountRepository:IRepositoryBase<Account>
    {
        IEnumerable<Account> AccountsByOwner(Guid ownerId);
    }
}
