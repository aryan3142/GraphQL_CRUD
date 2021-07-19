using GraphQLCRUD.Models;
using GraphQLCRUD.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLCRUD.Service
{
    public class GroupService : IGroupService
    {
        private IList<Group> _groups;

        public GroupService()
        {
            _groups = new List<Group>()
            {
                new Group(){GroupId = 1, Name = "Commerce", ShortName = "Com" },
                new Group(){GroupId = 2, Name = "Science", ShortName = "Sci" },
                new Group(){GroupId = 3, Name = "Arts", ShortName = "Ats" },
            };
        }
        public IQueryable<Group> GetAllGroup()
        {
            return _groups.AsQueryable();
        }
    }
}
