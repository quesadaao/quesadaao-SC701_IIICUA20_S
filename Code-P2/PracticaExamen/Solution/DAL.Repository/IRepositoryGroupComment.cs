using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using DO.Objects;

namespace DAL.Repository
{
    public interface IRepositoryGroupComment: IRepository<GroupComment>
    {
        //IEnumerable<GroupComment> GetAllWithGroupCommentsAsync();
        Task<IEnumerable<GroupComment>> GetAllWithGroupCommentsAsync();
        Task<GroupComment> GetWithGroupCommentByIdAsync(int id);
    }
}
