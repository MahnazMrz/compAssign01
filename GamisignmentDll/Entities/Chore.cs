using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamisignmentDll.Entities
{
    public class Chore : AbstractEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public Repeat Repeat { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int Point { get; set; }
    }
}
