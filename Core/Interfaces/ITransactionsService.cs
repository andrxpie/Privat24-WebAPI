using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Core.Interfaces
{
    public interface ITransactionsService
    {
        Task Create(CreateTransactionModel model);
        IEnumerable<TransactionDto> GetAllByUser(string userId);
    }
}
