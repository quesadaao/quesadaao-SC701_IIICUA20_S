using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DO.Objects;
using DAL.EF;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class RepositoryGroupComment : Repository<GroupComment>, IRepositoryGroupComment
    {
        public RepositoryGroupComment(SolutionDBContext context)
            : base(context)
        { }

        public async Task<IEnumerable<GroupComment>> GetAllWithGroupCommentsAsync()
        {
            return await SolutionDBContext.GroupComments
                .Include(m => m.GroupUpdate)
                .ToListAsync();
        }

        public async Task<GroupComment> GetWithGroupCommentByIdAsync(int id)
        {
            return await SolutionDBContext.GroupComments
                .Include(m => m.GroupUpdate)
                .SingleOrDefaultAsync(m => m.GroupUpdateId == id);
        }

        private SolutionDBContext SolutionDBContext
        {
            get { return dBContext as SolutionDBContext; }
        }
    }
}
