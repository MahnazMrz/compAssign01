using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamisignmentDll.Entities;

namespace GamisignmentDll.Managers
{
    internal class RepeatListManager : AbstractListManager<Repeat>
    {
        public override void Update(Repeat newObject, Repeat oldObject)
        {
            oldObject.TimesPrWeek = newObject.TimesPrWeek;
        }
    }
}
