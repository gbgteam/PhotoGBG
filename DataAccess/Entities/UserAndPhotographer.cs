using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessAbstraction.Entities;

namespace DataAccess.Entities
{
    class UserAndPhotographer:IUserAndPhotographer
    {
        public long id
        {
            get;
            set;
        }
        public string Username 
        {
            get; 
            set; 
        }
        public string Password 
        { 
            get; 
            set; 
        }
        public string Name 
        { 
            get; 
            set; 
        }
        public string Country 
        { 
            get; 
            set; 
        }
        public string City
        {
            get;
            set;
        }
        public string Telephone 
        { 
            get; 
            set; 
        }
        public string Description 
        { 
            get; 
            set; 
        }

        public long rol_id
        {
            get;
            set;

        }

    }
}
