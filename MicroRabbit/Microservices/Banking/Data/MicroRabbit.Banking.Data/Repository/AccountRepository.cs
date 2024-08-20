using MicroRabbit.Banking.Data.Context;
using MicroRabbit.Banking.Domain.Interfaces;
using MicroRabbit.Banking.Domain.Models;

namespace MicroRabbit.Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BakingDbContext _ctx;
        public AccountRepository(BakingDbContext ctx)
        {
            _ctx = ctx;
        }
        public IEnumerable<Account> GetAccounts()
        {
            return _ctx.Accounts;
        }
    }
}
