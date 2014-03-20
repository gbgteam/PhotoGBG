using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAbstraction.Entities
{
    interface IRolID
    {
        long id { get; set; }
        string rol_name { get; set; }
    }
}
