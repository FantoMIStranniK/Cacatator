namespace Cacatator
{
    public partial class Cacator : Form
    {
        private float? XNumber = null;
        private float? YNumber = null;

        public Cacator()
        {
            InitializeComponent();
        }

        private float? ParseInput(string input)
        {
            float number;

            bool result = float.TryParse(input, out number);

            if (result)
                return number;

            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            YNumber = ParseInput(textBox3.Text);
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            XNumber = ParseInput(textBox4.Text);
        }

        private void MultButton_Click(object sender, EventArgs e)
        {
            float? resultNum = XNumber * YNumber;

            ShowResult(resultNum.ToString());
        }

        private void SummButton_Click(object sender, EventArgs e)
        {
            float? resultNum = XNumber + YNumber;

            ShowResult(resultNum.ToString());
        }
        private void ShowResult(string message)
        {
            MessageBox.Show(message);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }
    }
}