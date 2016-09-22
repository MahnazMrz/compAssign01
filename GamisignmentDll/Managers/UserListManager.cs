using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamisignmentDll.Entities;

namespace GamisignmentDll.Managers
{
    internal class UserListManager : AbstractListManager<User>
    {
        public override void Update(User t, User user)
        {
            user.FirstName = t.FirstName;
            user.Email = t.Email;
            user.LastName = t.LastName;
            user.UserName = t.UserName;
            user.CompletedChores = new List<Chore>(t.CompletedChores);

        }
    }
}
