﻿using System;
using System.Collections.Generic;



namespace UI.Models
{
    public partial class Support
    {
        public int SupportId { get; set; }
        public int GoalId { get; set; }
        public string UserId { get; set; }
        public DateTime SupportedDate { get; set; }
    }
}
