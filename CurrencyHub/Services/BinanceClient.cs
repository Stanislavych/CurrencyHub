using Binance.Net.Clients;
using CryptoExchange.Net.Objects.Sockets;
using CurrencyHub.Interfaces;

namespace CurrencyHub.Services
{
    public class BinanceClient : IExchange
    {
        private BinanceSocketClient _binanceClient = new BinanceSocketClient();

        public async Task<UpdateSubscription> SubscribePriceAsync(string symbol, Action<decimal> handler, CancellationToken cancellationToken)
        {
            bool isHandled = false;

            var tickerSubscriptionResult = await _binanceClient.SpotApi.ExchangeData.SubscribeToTickerUpdatesAsync(symbol, data =>
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
            await _binanceClient.UnsubscribeAllAsync();
        }
    }
}
