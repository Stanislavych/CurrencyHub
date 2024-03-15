using CurrencyHub.Interfaces;
using CurrencyHub.Services;
using System.Collections.Concurrent;
using System.Text.RegularExpressions;

namespace CurrencyHub.Forms
{
    public partial class MainForm : Form
    {
        private ConcurrentDictionary<string, IExchange> _exchanges = new ConcurrentDictionary<string, IExchange>();
        private CancellationTokenSource _cts;

        public MainForm()
        {
            InitializeComponent();
            
            _exchanges["Binance"] = new BinanceClient();
            _exchanges["Bybit"] = new BybitClient();
            _exchanges["Kucoin"] = new KucoinClient();
            _exchanges["Bitget"] = new BitgetClient();

            comboBoxSymbols.Enabled = false;
            textBoxSymbol.Enabled = false;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            comboBoxSymbols.Items.AddRange(new object[] { "BTC-USDT", "ETH-USDT", "ETH-BTC", "AVAX-USDT" });
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string selectedSymbol;

            if (radioButtonComboBox.Checked)
            {
                selectedSymbol = (string)comboBoxSymbols.SelectedItem;

                if (string.IsNullOrEmpty(selectedSymbol))
                {
                    MessageBox.Show("Please select a symbol from the combobox.", "No Symbol Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    return;
                }
            }

            else if (radioButtonTextBox.Checked)
            {
                selectedSymbol = textBoxSymbol.Text.Trim().ToUpper();

                if (string.IsNullOrEmpty(selectedSymbol))
                {
                    MessageBox.Show("Please enter a symbol in the textbox.", "No Symbol Entered", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    return;
                }
                if (!selectedSymbol.Contains('-') || (selectedSymbol.IndexOf('-') != selectedSymbol.LastIndexOf('-')) || selectedSymbol.StartsWith("-")
                    || selectedSymbol.EndsWith("-") || Regex.IsMatch(selectedSymbol, @"[а-яА-Я]") || Regex.IsMatch(selectedSymbol, @"[^a-zA-Z0-9-]") || selectedSymbol.Length < 6)
                {
                    MessageBox.Show("Please specify a character in the format BTC-USDT. At least 6 characters", "Incorrect Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    
                    return;
                }
            }

            else
            {
                MessageBox.Show("Please select a search method.", "Method not defined", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return;
            }

            _cts?.Cancel();
            _cts = new CancellationTokenSource();

            CancellationToken cancellationToken = _cts.Token;

            while (true)
            {
                await SubscribeToPrice(selectedSymbol, cancellationToken);
                await Task.Delay(5000);
            }
        }

        private async void buttonCancel_Click(object sender, EventArgs e)
        {
            if (_cts != null)
            {
                _cts.Cancel();
            }

            foreach (var exchangeName in _exchanges.Keys)
            {
                var exchange = _exchanges[exchangeName];
                await exchange.UnsubscribeAllAsync();
            }

            labelBinancePrice.Text = "0";
            labelBybitPrice.Text = "0";
            labelBitgetPrice.Text = "0";
            labelKucoinPrice.Text = "0";
        }

        private async Task SubscribeToPrice(string symbol, CancellationToken cancellationToken)
        {
            List<Task> tasks = new List<Task>();

            foreach (var exchangeName in _exchanges.Keys)
            {
                var exchange = _exchanges[exchangeName];

                tasks.Add(Task.Run(async () =>
                {
                    await exchange.UnsubscribeAllAsync();

                    if (exchangeName != "Kucoin")
                    {
                        await exchange.SubscribePriceAsync(symbol.Replace("-", ""), async (price) => await UpdatePrice(price, exchangeName), cancellationToken);
                    }
                    else
                    {
                        await exchange.SubscribePriceAsync(symbol, async (price) => await UpdatePrice(price, exchangeName), cancellationToken);
                    }
                }));
            }

            await Task.WhenAll(tasks);
        }

        private async Task UpdatePrice(decimal price, string exchangeName)
        {
            await Task.Run(() =>
            {
                if (InvokeRequired)
                {
                    Invoke(new Action(() => UpdateLabel(exchangeName, price)));
                }
                else
                {
                    UpdateLabel(exchangeName, price);
                }
            });
        }

        private void UpdateLabel(string exchangeName, decimal price)
        {
            switch (exchangeName)
            {
                case "Binance":
                    labelBinancePrice.Text = price.ToString();
                    break;
                case "Bybit":
                    labelBybitPrice.Text = price.ToString();
                    break;
                case "Kucoin":
                    labelKucoinPrice.Text = price.ToString();
                    break;
                case "Bitget":
                    labelBitgetPrice.Text = price.ToString();
                    break;
            }
        }

        private void radioButtonComboBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonComboBox.Checked)
            {
                comboBoxSymbols.Enabled = true;
                textBoxSymbol.Enabled = false;
            }
        }

        private void radioButtonTextBox_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTextBox.Checked)
            {
                comboBoxSymbols.Enabled = false;
                textBoxSymbol.Enabled = true;
            }
        }
    }
}
