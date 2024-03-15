using CryptoExchange.Net.Objects.Sockets;

namespace CurrencyHub.Interfaces
{
    public interface IExchange
    {
        Task<UpdateSubscription> SubscribePriceAsync(string symbol, Action<decimal> handler, CancellationToken cancellationToken);
        Task UnsubscribeAllAsync();
    }
}
