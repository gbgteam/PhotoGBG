using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAbstraction.Entities
{
    public interface IUserAndPhotographer
    {
        long id { get; set; }
        string Username { get; set; }
        string Password { get; set; }
        string Name { get; set; }
        string Country { get; set; }
        string City { get; set; }
        string Telephone { get; set; }
        string Description { get; set; }
<<<<<<< HEAD
        long rol_id { get; set; }
=======
        int Role { get; set; }
>>>>>>> 515ef30dafdf14b7fd2b0ddfe1d7d2f63d376952
    }
}
