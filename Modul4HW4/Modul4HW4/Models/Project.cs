﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul4HW4.Models
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public decimal Budget { get; set; }
        public DateTime StartedTime { get; set; }
        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
