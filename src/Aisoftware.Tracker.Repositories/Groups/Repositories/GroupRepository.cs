using System.Threading.Tasks;
using Aisoftware.Tracker.Repositories.Groups.Interfaces;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Groups.Entities;

namespace Aisoftware.Tracker.Repositories.Groups.Repositories
{
    public class GroupRepository : IGroupRepository
    {
        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Group>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Group>> FindById(int? userId, bool? all)
        {
            throw new System.NotImplementedException();
        }

        public Task<Group> Save(Group request)
        {
            throw new System.NotImplementedException();
        }

        public Task<Group> Update(Group request)
        {
            throw new System.NotImplementedException();
        }
    }
}