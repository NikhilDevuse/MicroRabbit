namespace MicroRabbit.Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        IEnumerable<Models.Account> GetAccounts();
    }
}
