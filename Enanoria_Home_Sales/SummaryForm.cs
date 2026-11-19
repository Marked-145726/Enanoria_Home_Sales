using System;
using System.Windows.Forms;

namespace Enanoria_Home_Sales
{
    public partial class SummaryForm : Form
    {
        public SummaryForm(double dTotal, double eTotal, double fTotal)
        {
            InitializeComponent();

            double grandTotal = dTotal + eTotal + fTotal;

            label1.Text = "=== HOME SALES SUMMARY ===\n\n" +
                          "Danielle Total: " + dTotal.ToString("C") + "\n" +
                          "Edward Total:   " + eTotal.ToString("C") + "\n" +
                          "Fatima Total:   " + fTotal.ToString("C") + "\n\n" +
                          "Grand Total:    " + grandTotal.ToString("C");
        }
    }
}
