using Bybit.Net.Clients;
using CryptoExchange.Net.Objects.Sockets;
using CurrencyHub.Interfaces;

namespace CurrencyHub.Services
{
    public class BybitClient : IExchange
    {
        private BybitSocketClient _bybitClient = new BybitSocketClient();

        public async Task<UpdateSubscription> SubscribePriceAsync(string symbol, Action<decimal> handler, CancellationToken cancellationToken)
        {
            bool isHandled = false;

            var tickerSubscriptionResult = await _bybitClient.SpotV3Api.SubscribeToTickerUpdatesAsync(symbol, data =>
            {
                if (!isHandled)
                {
                    handler(data.Data.LastPrice);
                    isHandled = true;
                }
            }, cancellationToken);

            return tickerSubscriptionResult.Data;
        }

        public async Task UnsubscribeAllAsync()
        {
            await _bybitClient.UnsubscribeAllAsync();
        }
    }
}
