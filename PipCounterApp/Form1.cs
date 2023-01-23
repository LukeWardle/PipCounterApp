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
            decimal entryPrice = Convert.ToDecimal(entryPriceText.Text);
            decimal stopLoss = Convert.ToDecimal(stopLossText.Text);
            decimal exitPrice = Convert.ToDecimal(exitPriceText.Text);

            decimal riskCalculated = entryPrice - stopLoss;
            decimal rewardCalculated = exitPrice - entryPrice;

            riskTextBox.Text = riskCalculated.ToString();
            rewardTextBox.Text = rewardCalculated.ToString();

        }

        
    }
}