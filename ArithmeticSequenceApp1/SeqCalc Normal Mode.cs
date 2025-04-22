using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace ArithmeticSequenceApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // The Version Display
            Version version = Assembly.GetExecutingAssembly().GetName().Version;

            labelVersion.Text = $"Version {version.Major}.{version.Minor}.{version.Build}.{version.Revision}";

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Declare variables for u1, u2, d (common difference), and n
                double u1 = 0, u2 = 0, d = 0;
                int n = Convert.ToInt32(txtN.Text);  // Number of terms

                // Check if u1, u2, and d (common difference) are entered
                bool u1Entered = double.TryParse(txtU1.Text, out u1);
                bool u2Entered = double.TryParse(txtU2.Text, out u2);
                bool dEntered = double.TryParse(txtCommonDifference.Text, out d); // Get the common difference value

                // Case 1: If both u1 and u2 are provided, calculate the common difference (d)
                if (u1Entered && u2Entered && !dEntered)
                {
                    d = u2 - u1;  // Calculate the common difference
                    lblCommonDifference.Text = $"r الأساس {d}";
                    txtCommonDifference.Text = d.ToString();  // Display the calculated d in the textbox
                }
                // Case 2: If both u1 and d are provided, calculate u2
                else if (u1Entered && dEntered && !u2Entered)
                {
                    u2 = u1 + d;  // Calculate u2 from u1 and d
                    txtU2.Text = u2.ToString();  // Display the calculated u2 in the textbox
                }
                // Case 3: If both u2 and d are provided, calculate u1
                else if (u2Entered && dEntered && !u1Entered)
                {
                    u1 = u2 - d;  // Calculate u1 from u2 and d
                    txtU1.Text = u1.ToString();  // Display the calculated u1 in the textbox
                }
                // Case 4: If neither u1, u2, nor d are provided, show an error
                else if (!u1Entered && !u2Entered && !dEntered)
                {
                    MessageBox.Show("Please enter at least two values (u1, u2, or d).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Exit if inputs are missing
                }

                // Check if n (number of terms) is entered and is a valid integer
                if (n <= 0)
                {
                    MessageBox.Show("Please enter a valid number of terms (n).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;  // Exit if n is invalid
                }

                // Clear the ListBox before adding new values
                listBoxSequence.Items.Clear();

                // Add the header for the sequence
                listBoxSequence.Items.Add($"Arithmetic Sequence with {n} terms:");

                // Prepare the Chart (clear any existing data points)
                chartSequence.Series.Clear();  // Clear previous data
                var series = new Series("Sequence");  // Create a new Series for the sequence
                series.ChartType = SeriesChartType.Line;  // Set the chart type to Line graph
                series.BorderWidth = 3;  // Set the width of the line
                chartSequence.Series.Add(series);  // Add the series to the chart

                // Generate and display the arithmetic sequence, also populate the chart
                for (int i = 1; i <= n; i++)
                {
                    double term = u1 + (i - 1) * d;  // Formula for the nth term
                    listBoxSequence.Items.Add($"u{i} = {term}");

                    // Add the data point to the chart (x is i, y is the term)
                    chartSequence.Series["Sequence"].Points.AddXY(i, term);  // Add x (index) and y (term) to the chart
                }

                // Refresh the chart
                chartSequence.Invalidate();
            }
            catch (Exception ex)
            {
                // Handle invalid input
                MessageBox.Show("An error occurred while processing the input.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Creator: Test(Rabhi Ishak)\nParticipated\n-Mounib Samaran\n-Naoum Zakarian\n-Ayoub Lazreguen\n-Maache Walid\nProgram Purpose: حساب المتتالية الحسابية\nVersion:0.0.0.1\nProgram Name:SeqCalc\nAll Right Reserved At Test(The creator)\nWho I am?\nI am a 17 years old new programer, not the best but trying to be the best have fun using the programe\n ",
                "About",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Create an instance of the AdvancedForm
            AdvancedForm advancedForm = new AdvancedForm();

            // Register the FormClosed event to show the Normal Mode form when AdvancedForm is closed
            advancedForm.FormClosed += (s, args) => this.Show();

            // Show the AdvancedForm as a modal dialog
            advancedForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxSequence_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //redirect to update website
            System.Diagnostics.Process.Start("https://github.com/Test-Labs-source/SeqCalc");
        }
    }
}
