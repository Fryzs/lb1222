namespace lb122
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CreditCalculator calculator = new CreditCalculator();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxMonths_TextChanged(object sender, EventArgs e)
        {

        }
        private ICreditStrategy GetSelectedStrategy()
        {
            switch (comboBoxBank.SelectedItem.ToString())
            {
                case "PrivatBank":
                    return new PrivatBankStrategy();

                case "MonoBank":
                    return new MonoBankStrategy();

                case "OschadBank":
                    return new OschadBankStrategy();

                default:
                    return null;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double amount = Convert.ToDouble(textBoxAmount.Text);
                int months = Convert.ToInt32(textBoxMonths.Text);

                ICreditStrategy strategy = GetSelectedStrategy();
                calculator.SetStrategy(strategy);

                double overpayment = calculator.Calculate(amount, months);

                labelResult.Text = "Overpayment: " + overpayment.ToString("F2") + " UAH";
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
        }
    }
}
