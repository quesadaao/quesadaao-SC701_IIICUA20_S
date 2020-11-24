﻿using System;
using System.Collections.Generic;



namespace API.W.Models
{
    public partial class Goal
    {
        public int GoalId { get; set; }
        public string GoalName { get; set; }
        public string Desc { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public double? Target { get; set; }
        public bool GoalType { get; set; }
        public int? MetricId { get; set; }
        public int GoalStatusId { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual AspNetUser User { get; set; }
    }
}
