using Bitget.Net.Clients;
using CryptoExchange.Net.Objects.Sockets;
using CurrencyHub.Interfaces;

namespace CurrencyHub.Services
{
    internal class BitgetClient : IExchange
    {
        private BitgetSocketClient _bitgetClient = new BitgetSocketClient();

        public async Task<UpdateSubscription> SubscribePriceAsync(string symbol, Action<decimal> handler, CancellationToken cancellationToken)
        {
            bool isHandled = false;

            var tickerSubscriptionResult = await _bitgetClient.SpotApi.SubscribeToTickerUpdatesAsync(symbol, data =>
            {
                if (!isHandled)
                {
                    handler(data.Data.LastPrice);
                    isHandled = true;
                }
            },cancellationToken);

            return tickerSubscriptionResult.Data;
        }

        public async Task UnsubscribeAllAsync()
        {
            await _bitgetClient.UnsubscribeAllAsync();
        }
    }
}
