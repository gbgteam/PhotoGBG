using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAbstraction.Entities
{
    public interface IPhoto
    {
        long Id { get; set; }
        string Link { get; set; }
        long AddedBy { get; set; } //id field from user db
        long Views { get; set; }
        long Likes { get; set; }
        string Description { get; set; }
    }
}
