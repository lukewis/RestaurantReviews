﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantReviews.Config
{
    public class AppConfiguration
    {
        public bool DropDb { get; set; }
        public AppConnectionStrings ConnectionStrings { get; set; }
    }

    public class AppConnectionStrings
    {
        public string Default { get; set; }
    }
}
