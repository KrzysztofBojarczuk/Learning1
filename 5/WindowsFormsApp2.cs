namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(inputTextBox.Text);

                if(number >= 1 && number <= 10)
                {
                    MessageBox.Show("Liczba została zaakcetowana.");
                }
                else
                {
                    MessageBox.Show("Liczba nie została zaakcetowana.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
