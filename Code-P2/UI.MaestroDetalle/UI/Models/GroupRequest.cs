﻿using System;
using System.Collections.Generic;

#nullable disable

namespace UI.Models
{
    public partial class GroupRequest
    {
        public int GroupRequestId { get; set; }
        public int GroupId { get; set; }
        public string UserId { get; set; }
        public bool Accepted { get; set; }

        public virtual Group Group { get; set; }
        public virtual AspNetUser User { get; set; }
    }
}
