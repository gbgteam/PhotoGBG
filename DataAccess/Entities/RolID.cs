using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessAbstraction.Entities;

namespace DataAccess.Entities
{
    class RolID:IRolID
    {
        public long id
        {
            get;
            set;
        }
        public string rol_name
        {
            get;
            set;
        }
    }
}
