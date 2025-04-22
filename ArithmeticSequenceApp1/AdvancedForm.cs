using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Reflection;

namespace ArithmeticSequenceApp1
{
    public partial class AdvancedForm : Form
    {
        public AdvancedForm()
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
                // Input Validation
                if (string.IsNullOrEmpty(txtNumTerms.Text) || !int.TryParse(txtNumTerms.Text, out int numTerms) || numTerms <= 0)
                {
                    MessageBox.Show("Please enter a valid number of terms (n).");
                    return;
                }

                //Cheking if term 1 and term 2 are the same soo the program show an error dialoge box
                int rank1 = int.Parse(txtRank1.Text);  // Rank of the first term
                int rank2 = int.Parse(txtRank2.Text);  // Rank of the second term

                if (rank1 == rank2)
                {
                    MessageBox.Show("The ranks must be different.");
                    return;
                }

                //checking the imputs type to avoid any wrong type of inpute such as string
                if (!double.TryParse(txtTerm1.Text, out double term1) || !double.TryParse(txtTerm2.Text, out double term2))
                {
                    MessageBox.Show("Please enter valid numeric values for the terms.");
                    return;
                }

                //Calculate the r (I named in this program (d))
                double d = (term2 - term1) / (rank2 - rank1);
                txtCommonDifference.Text = d.ToString();

                //Calculate (u1)
                double u1 = term1 - (rank1 - 1) * d;
                txtFirstTerm.Text = u1.ToString();

                //Call PlotSequence to plot the chart
                PlotSequence(u1, d, numTerms);

                // Step 4: Populate the ListBox with the sequence terms
                lstSequence.Items.Clear(); // Clear any previous items in the ListBox

                for (int n = 1; n <= numTerms; n++)
                {
                    double term = u1 + (n - 1) * d;
                    lstSequence.Items.Add("u" + n + " = " + term.ToString("F2")); // Add the term to the ListBox, formatted to 2 decimal places
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void PlotSequence(double u1, double d, int numTerms)
        {
            //clear old data in the old calculated chart
            chartSequence.Series.Clear();

            //Creat a serie called Arthmetic Sequence to be used in the futer in chart creating
            var series = new System.Windows.Forms.DataVisualization.Charting.Series("Arithmetic Sequence");

            //Seting chart type to line graph
            series.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

            // Loop through and plot the sequence points and let the limits to be equqled to the numterm and let hhim progress in chart
            for (int n = 1; n <= numTerms; n++)
            {
                //Calculating the nth term depending on user inputs and put them in the chart(Graph)
                double term = u1 + (n - 1) * d;

                //Creating the x,y values depending on our user data and calculations
                series.Points.AddXY(n, term);
            }

            // Add the series to the chart
            chartSequence.Series.Add(series);
        }
            //Exit button
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
            //Create the switch button scripte
        private void btnSwitchMode_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //redirect to update website
            System.Diagnostics.Process.Start("https://github.com/Test-Labs-source/SeqCalc");
        }
    }
}
