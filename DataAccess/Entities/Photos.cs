using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessAbstraction.Entities;

namespace DataAccess.Entities
{
    public class Photos:IPhoto
    {
        public long Id
        {
            get;
            set;
        }
        public string Link
        {
            get;
            set;
        }
        public string AddedBy
        {
            get;
            set;
        }
        public long Views
        {
            get;
            set;
        }
        public long Likes
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
    }
}
