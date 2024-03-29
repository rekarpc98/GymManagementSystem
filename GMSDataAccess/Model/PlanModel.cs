﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMSDataAccess.Model;
public class PlanModel {
    public int Id { get; set; }
    public string Name { get; set; }
    public DateTime Start { get; set; }
    public DateTime End { get; set; }
    public int Fee { get; set; }

    public string Display {
        get { return $"{Name}({Fee})"; }
    }

}
