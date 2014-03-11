using DataAccessAbstraction.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entities
{
    public class Tag:ITag
    {
        public long Id
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string AddedBy
        {
            get;
            set;
        }
    }
}
