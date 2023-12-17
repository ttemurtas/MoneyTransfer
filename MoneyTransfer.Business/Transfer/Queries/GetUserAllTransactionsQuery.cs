﻿using MediatR;
using MoneyTransfer.Business.Models.Models.ViewTransaction.Req;
using MoneyTransfer.Business.Models.Models.ViewTransaction.Res;

namespace MoneyTransfer.Business.Transfer.Queries
{
    public record GetUserAllTransactionsQuery(ViewTransactionRequest request) : IRequest<List<ViewTransactionResponse>>;
}
