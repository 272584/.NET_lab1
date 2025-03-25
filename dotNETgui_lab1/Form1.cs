using System;
using System.Windows.Forms;
using KnapsackProblem;

namespace KnapsackGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfItems = int.Parse(txtNumberOfItems.Text);
                int seed = int.Parse(txtSeed.Text);
                int capacity = int.Parse(txtCapacity.Text);

                Problem problem = new Problem(numberOfItems, seed);
                Result result = problem.Solve(capacity);

                txtResults.Text = $"Items: {string.Join(" ", result.SelectedItems)}\n\n" +
                                  $"Total Value: {result.TotalValue}\n\n" +
                                  $"Total Weight: {result.TotalWeight}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("B³¹d: " + ex.Message, "Wyst¹pi³ b³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtResults_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
