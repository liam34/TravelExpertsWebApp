﻿using System;
using System.Collections.Generic;

namespace TravelExpertsWebApp.Models
{
    public partial class CustomersRewards
    {
        public int CustomerId { get; set; }
        public int RewardId { get; set; }
        public string RwdNumber { get; set; }
    }
}
