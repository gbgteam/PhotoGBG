﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessAbstraction.Entities
{
    public interface IPhotoTagUnion
    {
        string PhotoId { get; set; }
        long TagId { get; set; }
    }
}
