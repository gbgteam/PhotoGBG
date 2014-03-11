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
        string AddedBy { get; set; } //username field from user db
        long Views { get; set; }
        long Likes { get; set; }
        string Description { get; set; }
    }
}
