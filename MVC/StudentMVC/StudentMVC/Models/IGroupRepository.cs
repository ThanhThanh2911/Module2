﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentMVC.Models
{
    public interface IGroupRepository
    {
        IEnumerable<Group> GetAll { get; }
    }
}