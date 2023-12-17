using MoneyTransfer.Concrete.AppUser;

namespace MoneyTransfer.Abstract.Interface.Login
{
    public interface ILogin
    {
        AppUser login(ILoginRequest request);
    }
}
