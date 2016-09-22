using GamisignmentDll.Entities;
using GamisignmentDll.Managers;

namespace GamisignmentDll
{
    public class DllFacade
    {
        public IManager<User> GetUserManager()
        {
            return new UserListManager();
        }

        public IManager<Repeat> GetRepeatManager()
        {
            //return new RepeatManager();
            return new RepeatListManager();
        }

        public IManager<Prize> GetPrizeManager()
        {
            return new PrizeListManager();
        }
    }
}
