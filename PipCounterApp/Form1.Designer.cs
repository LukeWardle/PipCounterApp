namespace PipCounterApp
{
    partial class PipCounterBox
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.entryPriceLabel = new System.Windows.Forms.Label();
            this.stopLossLabel = new System.Windows.Forms.Label();
            this.entryPriceText = new System.Windows.Forms.TextBox();
            this.stopLossText = new System.Windows.Forms.TextBox();
            this.exitPriceLabel = new System.Windows.Forms.Label();
            this.exitPriceText = new System.Windows.Forms.TextBox();
            this.riskTextBox = new System.Windows.Forms.TextBox();
            this.rewardTextBox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entryPriceLabel
            // 
            this.entryPriceLabel.AutoSize = true;
            this.entryPriceLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.entryPriceLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.entryPriceLabel.Location = new System.Drawing.Point(235, 54);
            this.entryPriceLabel.Name = "entryPriceLabel";
            this.entryPriceLabel.Size = new System.Drawing.Size(121, 24);
            this.entryPriceLabel.TabIndex = 0;
            this.entryPriceLabel.Text = "Entry Price";
            // 
            // stopLossLabel
            // 
            this.stopLossLabel.AutoSize = true;
            this.stopLossLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.stopLossLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stopLossLabel.Location = new System.Drawing.Point(258, 90);
            this.stopLossLabel.Name = "stopLossLabel";
            this.stopLossLabel.Size = new System.Drawing.Size(98, 24);
            this.stopLossLabel.TabIndex = 1;
            this.stopLossLabel.Text = "Stop Loss";
            // 
            // entryPriceText
            // 
            this.entryPriceText.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.entryPriceText.Location = new System.Drawing.Point(362, 51);
            this.entryPriceText.Name = "entryPriceText";
            this.entryPriceText.Size = new System.Drawing.Size(179, 28);
            this.entryPriceText.TabIndex = 2;
            // 
            // stopLossText
            // 
            this.stopLossText.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stopLossText.Location = new System.Drawing.Point(362, 89);
            this.stopLossText.Name = "stopLossText";
            this.stopLossText.Size = new System.Drawing.Size(179, 28);
            this.stopLossText.TabIndex = 3;
            // 
            // exitPriceLabel
            // 
            this.exitPriceLabel.AutoSize = true;
            this.exitPriceLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.exitPriceLabel.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitPriceLabel.Location = new System.Drawing.Point(247, 127);
            this.exitPriceLabel.Name = "exitPriceLabel";
            this.exitPriceLabel.Size = new System.Drawing.Size(109, 24);
            this.exitPriceLabel.TabIndex = 4;
            this.exitPriceLabel.Text = "Exit Price";
            // 
            // exitPriceText
            // 
            this.exitPriceText.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exitPriceText.Location = new System.Drawing.Point(362, 127);
            this.exitPriceText.Name = "exitPriceText";
            this.exitPriceText.Size = new System.Drawing.Size(179, 28);
            this.exitPriceText.TabIndex = 5;
            // 
            // riskTextBox
            // 
            this.riskTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.riskTextBox.Location = new System.Drawing.Point(282, 291);
            this.riskTextBox.Name = "riskTextBox";
            this.riskTextBox.Size = new System.Drawing.Size(100, 30);
            this.riskTextBox.TabIndex = 6;
            // 
            // rewardTextBox
            // 
            this.rewardTextBox.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rewardTextBox.Location = new System.Drawing.Point(388, 291);
            this.rewardTextBox.Name = "rewardTextBox";
            this.rewardTextBox.Size = new System.Drawing.Size(100, 30);
            this.rewardTextBox.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.Firebrick;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.calculateButton.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.calculateButton.Location = new System.Drawing.Point(324, 253);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(122, 32);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // PipCounterBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::PipCounterApp.Properties.Resources.tradingbullbear;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.rewardTextBox);
            this.Controls.Add(this.riskTextBox);
            this.Controls.Add(this.exitPriceText);
            this.Controls.Add(this.exitPriceLabel);
            this.Controls.Add(this.stopLossText);
            this.Controls.Add(this.entryPriceText);
            this.Controls.Add(this.stopLossLabel);
            this.Controls.Add(this.entryPriceLabel);
            this.Name = "PipCounterBox";
            this.RightToLeftLayout = true;
            this.Text = "Pip Counter App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label entryPriceLabel;
        private Label stopLossLabel;
        private TextBox entryPriceText;
        private TextBox stopLossText;
        private Label exitPriceLabel;
        private TextBox exitPriceText;
        private TextBox riskTextBox;
        private TextBox rewardTextBox;
        private Button calculateButton;
    }
}