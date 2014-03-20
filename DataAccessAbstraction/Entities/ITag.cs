using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAbstraction.Entities
{
    public interface ITag
    {
        int Id { get; set; }
        string Name { get; set; }
        long AddedBy { get; set; } //id field from user db
    }
}
