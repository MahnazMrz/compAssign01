using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamisignmentDll.Entities
{
    public class Prize : AbstractEntity
    {
        public int Points { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

    }
}
