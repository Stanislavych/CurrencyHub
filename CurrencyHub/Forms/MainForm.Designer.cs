namespace CurrencyHub.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelBinance = new Label();
            labelBybit = new Label();
            labelKucoin = new Label();
            labelBitGet = new Label();
            labelBinancePrice = new Label();
            labelBybitPrice = new Label();
            labelKucoinPrice = new Label();
            labelBitgetPrice = new Label();
            comboBoxSymbols = new ComboBox();
            buttonSearch = new Button();
            buttonCancel = new Button();
            label1 = new Label();
            textBoxSymbol = new TextBox();
            radioButtonTextBox = new RadioButton();
            radioButtonComboBox = new RadioButton();
            SuspendLayout();
            // 
            // labelBinance
            // 
            labelBinance.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelBinance.Location = new Point(12, 88);
            labelBinance.Name = "labelBinance";
            labelBinance.Size = new Size(99, 51);
            labelBinance.TabIndex = 0;
            labelBinance.Text = "Binance";
            // 
            // labelBybit
            // 
            labelBybit.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelBybit.Location = new Point(12, 117);
            labelBybit.Name = "labelBybit";
            labelBybit.Size = new Size(93, 51);
            labelBybit.TabIndex = 1;
            labelBybit.Text = "Bybit";
            // 
            // labelKucoin
            // 
            labelKucoin.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelKucoin.Location = new Point(12, 150);
            labelKucoin.Name = "labelKucoin";
            labelKucoin.Size = new Size(93, 51);
            labelKucoin.TabIndex = 2;
            labelKucoin.Text = "Kucoin";
            // 
            // labelBitGet
            // 
            labelBitGet.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            labelBitGet.Location = new Point(12, 185);
            labelBitGet.Name = "labelBitGet";
            labelBitGet.Size = new Size(93, 51);
            labelBitGet.TabIndex = 3;
            labelBitGet.Text = "BitGet";
            // 
            // labelBinancePrice
            // 
            labelBinancePrice.AutoSize = true;
            labelBinancePrice.Location = new Point(117, 97);
            labelBinancePrice.Name = "labelBinancePrice";
            labelBinancePrice.Size = new Size(17, 20);
            labelBinancePrice.TabIndex = 4;
            labelBinancePrice.Text = "0";
            // 
            // labelBybitPrice
            // 
            labelBybitPrice.AutoSize = true;
            labelBybitPrice.Location = new Point(117, 126);
            labelBybitPrice.Name = "labelBybitPrice";
            labelBybitPrice.Size = new Size(17, 20);
            labelBybitPrice.TabIndex = 5;
            labelBybitPrice.Text = "0";
            // 
            // labelKucoinPrice
            // 
            labelKucoinPrice.AutoSize = true;
            labelKucoinPrice.Location = new Point(117, 159);
            labelKucoinPrice.Name = "labelKucoinPrice";
            labelKucoinPrice.Size = new Size(17, 20);
            labelKucoinPrice.TabIndex = 6;
            labelKucoinPrice.Text = "0";
            // 
            // labelBitgetPrice
            // 
            labelBitgetPrice.AutoSize = true;
            labelBitgetPrice.Location = new Point(117, 194);
            labelBitgetPrice.Name = "labelBitgetPrice";
            labelBitgetPrice.Size = new Size(17, 20);
            labelBitgetPrice.TabIndex = 7;
            labelBitgetPrice.Text = "0";
            // 
            // comboBoxSymbols
            // 
            comboBoxSymbols.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxSymbols.FormattingEnabled = true;
            comboBoxSymbols.Location = new Point(352, 49);
            comboBoxSymbols.Margin = new Padding(3, 4, 3, 4);
            comboBoxSymbols.Name = "comboBoxSymbols";
            comboBoxSymbols.Size = new Size(138, 28);
            comboBoxSymbols.TabIndex = 8;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(17, 239);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(117, 37);
            buttonSearch.TabIndex = 9;
            buttonSearch.Text = "Поиск";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(140, 239);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(117, 37);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(305, 45);
            label1.TabIndex = 11;
            label1.Text = "Укажите пару для поиска";
            // 
            // textBoxSymbol
            // 
            textBoxSymbol.Location = new Point(555, 49);
            textBoxSymbol.Name = "textBoxSymbol";
            textBoxSymbol.PlaceholderText = "BTC-USDT";
            textBoxSymbol.Size = new Size(125, 27);
            textBoxSymbol.TabIndex = 12;
            // 
            // radioButtonTextBox
            // 
            radioButtonTextBox.AutoSize = true;
            radioButtonTextBox.Location = new Point(532, 54);
            radioButtonTextBox.Name = "radioButtonTextBox";
            radioButtonTextBox.Size = new Size(17, 16);
            radioButtonTextBox.TabIndex = 13;
            radioButtonTextBox.TabStop = true;
            radioButtonTextBox.UseVisualStyleBackColor = true;
            radioButtonTextBox.CheckedChanged += radioButtonTextBox_CheckedChanged;
            // 
            // radioButtonComboBox
            // 
            radioButtonComboBox.AutoSize = true;
            radioButtonComboBox.Location = new Point(329, 54);
            radioButtonComboBox.Name = "radioButtonComboBox";
            radioButtonComboBox.Size = new Size(17, 16);
            radioButtonComboBox.TabIndex = 14;
            radioButtonComboBox.TabStop = true;
            radioButtonComboBox.UseVisualStyleBackColor = true;
            radioButtonComboBox.CheckedChanged += radioButtonComboBox_CheckedChanged;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(706, 309);
            Controls.Add(radioButtonComboBox);
            Controls.Add(radioButtonTextBox);
            Controls.Add(textBoxSymbol);
            Controls.Add(label1);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSearch);
            Controls.Add(comboBoxSymbols);
            Controls.Add(labelBitgetPrice);
            Controls.Add(labelKucoinPrice);
            Controls.Add(labelBybitPrice);
            Controls.Add(labelBinancePrice);
            Controls.Add(labelBitGet);
            Controls.Add(labelKucoin);
            Controls.Add(labelBybit);
            Controls.Add(labelBinance);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelBinance;
        private Label labelBybit;
        private Label labelKucoin;
        private Label labelBitGet;
        private Label labelBinancePrice;
        private Label labelBybitPrice;
        private Label labelKucoinPrice;
        private Label labelBitgetPrice;
        private ComboBox comboBoxSymbols;
        private Button buttonSearch;
        private Button buttonCancel;
        private Label label1;
        private TextBox textBoxSymbol;
        private RadioButton radioButtonTextBox;
        private RadioButton radioButtonComboBox;
    }
}