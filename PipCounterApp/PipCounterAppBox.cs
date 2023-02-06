using PipCounterApp.ClassLibrary;
using System.Drawing.Text;
using System.Windows.Forms;



namespace PipCounterApp
{
    public partial class PipCounterBox : Form
    {
        public PipCounterBox()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {

            //validation check
            bool isValidEntryPrice = ConvertUserInputData.CheckUserInputIsNotNullOrWhiteSpace(entryPriceText.Text);
            bool isValidStopLoss = ConvertUserInputData.CheckUserInputIsNotNullOrWhiteSpace(stopLossText.Text);
            bool isValidExitPrice = ConvertUserInputData.CheckUserInputIsNotNullOrWhiteSpace(exitPriceText.Text);
            if (isValidEntryPrice != true || isValidStopLoss != true || isValidExitPrice != true)
            {
                MessageBox.Show("Please enter a valid decimal number.", "Blank Message Field(s).", MessageBoxButtons.OK, MessageBoxIcon.Error);
                entryPriceText.Clear();
                stopLossText.Clear();
                exitPriceText.Clear();
                entryPriceText.Focus();
            }
            else
            {
                decimal entryPrice = ConvertUserInputData.ConvertInputDataToDecimal(entryPriceText.Text);
                decimal stopLoss = ConvertUserInputData.ConvertInputDataToDecimal(stopLossText.Text);
                decimal exitPrice = ConvertUserInputData.ConvertInputDataToDecimal(exitPriceText.Text);
                if (entryPrice == 0)
                {
                    MessageBox.Show("Please enter a valid entry price number.", "Invalid entry price.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    entryPriceText.Clear();
                    stopLossText.Clear();
                    exitPriceText.Clear();
                    entryPriceText.Focus();
                }
                else if (stopLoss == 0) 
                {
                    MessageBox.Show("Please enter a valid stop loss number.", "Invalid stop loss price.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    entryPriceText.Clear();
                    stopLossText.Clear();
                    exitPriceText.Clear();
                    entryPriceText.Focus();
                }
                else if (exitPrice == 0)
                {
                    MessageBox.Show("Please enter a valid exit price number.", "Invalid exit price.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    entryPriceText.Clear();
                    stopLossText.Clear();
                    exitPriceText.Clear();
                    entryPriceText.Focus();
                }
                else
                {
                    riskTextBox.Text = CalculateData.CalculateRisk(entryPrice, stopLoss).ToString();
                    rewardTextBox.Text = CalculateData.CalculateReward(exitPrice, entryPrice).ToString();
                }
                
            } 
        }
    }
}