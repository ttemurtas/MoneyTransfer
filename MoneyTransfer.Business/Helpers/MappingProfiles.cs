using AutoMapper;
using MoneyTransfer.Business.Models.Models.BalanceView.Res;
using MoneyTransfer.Business.Models.Models.SendMoney.Res;
using MoneyTransfer.Business.Models.Models.ViewTransaction.Res;
using MoneyTransfer.Concrete.AppUser;
using MoneyTransfer.Concrete.Transfer;

namespace MoneyTransfer.Business.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<SendMoneyResponse, Transaction>();
            CreateMap<Transaction, SendMoneyResponse>(MemberList.Source);
            CreateMap<ViewTransactionResponse, Transaction>(MemberList.Source);
            CreateMap<Transaction, ViewTransactionResponse>(MemberList.Source);
            CreateMap<AppUser, GetUserBalanceViewResponse>(MemberList.Source);
            CreateMap<GetUserBalanceViewResponse, AppUser>(MemberList.Source);
        }
    }
}
