using MoneyTransfer.Concrete.Common;

namespace MoneyTransfer.Concrete.Login
{
    public class LoginRequest : BaseUser
    {
        private readonly BaseUser _user;
        public LoginRequest(BaseUser user)
        {
            _user = user;
        }
    }
}
