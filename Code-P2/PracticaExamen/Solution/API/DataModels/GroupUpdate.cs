using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DataModels
{
    public class GroupUpdate
    {
        public int GroupUpdateId { get; set; }
        public string Updatemsg { get; set; }
        public double? Status { get; set; }
        public int GroupGoalId { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
