using BangServer.Core.Entity.ExtendedModels;
using BangServer.Core.Entity.Models;
using System;
using System.Collections.Generic;

namespace BangServer.Core.Interfaces
{
    public interface IOwnerRepository:IRepositoryBase<Owner>
    {
        IEnumerable<Owner> GetAllOwners();
        Owner GetOwnerById(Guid ownerId);
        OwnerExtended GetOwnerWithDetails(Guid ownerId);
        void CreateOwner(Owner owner);
        void UpdateOwner(Owner dbOwner, Owner owner);
        void DeleteOwner(Owner owner);
    }
}
