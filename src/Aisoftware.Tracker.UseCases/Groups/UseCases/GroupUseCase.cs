using System.Threading.Tasks;
using Aisoftware.Tracker.UseCases.Groups.Interfaces;
using System.Collections.Generic;
using Aisoftware.Tracker.Borders.Groups.DTO;

namespace Aisoftware.Tracker.UseCases.Groups.UseCases
{
    public class GroupUseCase : IGroupUseCase
    {
        public Task Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<GroupDTO>> FindAll()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<GroupDTO>> FindById(int? userId, bool? all)
        {
            throw new System.NotImplementedException();
        }

        public Task<GroupDTO> Save(GroupDTO request)
        {
            throw new System.NotImplementedException();
        }

        public Task<GroupDTO> Update(GroupDTO request)
        {
            throw new System.NotImplementedException();
        }
    }
}