using KnapsackProblem;

namespace KnapsackGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonRun_Click(object sender, EventArgs e)
        {
            bool isError = false;

            if(!int.TryParse(textBoxNumberOfItems.Text, out int numberOfItems) || numberOfItems <= 0)
            {
                textBoxNumberOfItems.BackColor = Color.LightCoral;
                isError = true;
            }

            if(!int.TryParse(textBoxSeed.Text, out int seed))
            {
                textBoxSeed.BackColor = Color.LightCoral;
                isError = true;
            }

            if(!int.TryParse(textBoxCapacity.Text, out int capacity) || capacity < 0)
            {
                textBoxCapacity.BackColor = Color.LightCoral;
                isError = true;
            }

            if(!isError)
            {
                try
                {
                    Problem problem = new Problem(numberOfItems, seed);
                    textBoxItems.Text = problem.ToString();

                    Result result = problem.Solve(capacity);
                    textBoxResults.Text = result.ToString(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
