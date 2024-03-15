using CryptoExchange.Net.Objects.Sockets;
using CurrencyHub.Interfaces;
using Kucoin.Net.Clients;

namespace CurrencyHub.Services
{
    public class KucoinClient : IExchange
    {
        private KucoinSocketClient _kucoinClient = new KucoinSocketClient();

        public async Task<UpdateSubscription> SubscribePriceAsync(string symbol, Action<decimal> handler, CancellationToken cancellationToken)
        {
            bool isHandled = false;

            var tickerSubscriptionResult = await _kucoinClient.SpotApi.SubscribeToTickerUpdatesAsync(symbol, data =>
            {
                if (!isHandled)
                {
                    handler(data.Data.LastPrice.Value);
                    isHandled = true;
                }
            },cancellationToken);

            return tickerSubscriptionResult.Data;
        }

        public async Task UnsubscribeAllAsync()
        {
            await _kucoinClient.UnsubscribeAllAsync();
        }
    }
}
