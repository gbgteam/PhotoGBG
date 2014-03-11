using DataAccessAbstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAbstraction.Repository
{
    public interface ITagRepository
    {
        IOperationResponse<ITag> Add(ITag tag);
        IOperationResponse<ITag> Edit(ITag tag);
        IOperationResponse Delete(long id);
        IOperationResponse<List<ITag>> GetAllPredefinedTags();
    }
}
