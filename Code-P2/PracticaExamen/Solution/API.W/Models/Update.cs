﻿using System;
using System.Collections.Generic;



namespace API.W.Models
{
    public partial class Update
    {
        public int UpdateId { get; set; }
        public string Updatemsg { get; set; }
        public double? Status { get; set; }
        public int GoalId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
