﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public double Percentage { get; set; }
        public int NumOFEmployees { get; set; }

        public override string ToString()
        {
            return Title;
        }
    }
}
