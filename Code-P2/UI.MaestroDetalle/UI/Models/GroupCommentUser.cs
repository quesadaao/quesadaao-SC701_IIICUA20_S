using System;
using System.Collections.Generic;

#nullable disable

namespace UI.Models
{
    public partial class GroupCommentUser
    {
        public int GroupCommentUserId { get; set; }
        public int GroupCommentId { get; set; }
        public string UserId { get; set; }
    }
}
