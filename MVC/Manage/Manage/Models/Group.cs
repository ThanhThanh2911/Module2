﻿using System.Collections.Generic;

namespace Manage.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string GroupName { get; set; }

        public List<Student> Students { get; set; }
    }
}