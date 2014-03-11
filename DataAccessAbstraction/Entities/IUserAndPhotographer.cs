using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAbstraction.Entities
{
    public interface IUserAndPhotographer
    {
        string Username { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        string Country { get; set; }
        string Telephone { get; set; }
        string Description { get; set; }
        Boolean Photographer { get; set; }
    }
}
