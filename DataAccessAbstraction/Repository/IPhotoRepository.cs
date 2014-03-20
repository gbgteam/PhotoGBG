using DataAccessAbstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAbstraction.Repository
{
    public interface IPhotoRepository
    {
        IOperationResponse<IPhoto> AddPhoto();
        IOperationResponse<string> DeletePhoto();
        IOperationResponse<IPhoto> UpdatePhoto();
    }
}
