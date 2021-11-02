using System.Collections.Generic;
using System.Threading.Tasks;
using Aisoftware.Tracker.Borders.Permissions.Entities;
using Aisoftware.Tracker.Repositories.Permissions.Interfaces;

namespace Aisoftware.Tracker.Repositories.Permissions.Repositories
{
    public class PermissionRepository : IPermissionRepository
    {
        public Task<Permission> Delete(Permission request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Permission> Save(Permission request)
        {
            throw new System.NotImplementedException();
        }
    }
}