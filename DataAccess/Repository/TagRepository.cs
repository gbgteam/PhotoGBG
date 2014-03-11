using DataAccessAbstraction;
using DataAccessAbstraction.Entities;
using DataAccessAbstraction.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataAccess.Repository
{
    public class TagRepository:ITagRepository
    {
        private string _connectionString;

        private const string GET_ALL_TAGS = @"SELECT * FROM [dbo].[Tag]";

        public TagRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IOperationResponse<ITag> Add(ITag tag)
        {
            try
            {
                SqlParameter param = new SqlParameter();
                param.Value = tag;

                SqlCommand command = new SqlCommand();


                return new OperationResponse<ITag>()
                {
                    Value = null,
                    IsSuccess = true

                };
            }
            catch(Exception ex)
            {
                return new OperationResponse<ITag>() { 
                    Value=null,
                    Message = ex.ToString(),
                    IsSuccess = false
                
                };
            }
        }

        public IOperationResponse<List<ITag>> GetAllPredefinedTags()
        {
            try
            {
                List<ITag> list = new List<ITag>();
                DataSet ds = new DataSet();

                System.Data.SqlClient();

                return new OperationResponse<List<ITag>>()
                {
                    IsSuccess = true
                };
            }
            catch (Exception ex)
            {
                return new OperationResponse<List<ITag>>() {
                    Value = null,
                    Message = ex.ToString(),
                    IsSuccess = false
                };
            }
     
        }
    }
}
