using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enanoria_Home_Sales
{
    public partial class Form1 : Form
    {


        double danielleTotal = 0;
        double edwardTotal = 0;
        double fatimaTotal = 0;



        public Form1()
        {
            InitializeComponent();
        }

        private void getSalesPerson_Amount(String salesInitial, double salesAmount)
        {
            string code = salesInitial.ToUpper();

            if (code == "D")
            {
                danielleTotal += salesAmount;
                label4.Text = "Transaction is recorded for Danielle.\n" +
                              "Danielle Total Sales: " + danielleTotal.ToString("C");
            }

            else if (code == "E")

            {
                edwardTotal += salesAmount;
                label4.Text = "Transaction is recorded for Edward.\n" +
                              "Edward Total Sales: " + edwardTotal.ToString("C");
            }

            else if (code == "F")

            {
                fatimaTotal += salesAmount;
                label4.Text = "Transaction recorded for Fatima.\n" +
                              "Fatima Total Sales: " + fatimaTotal.ToString("C");
            }

            else


            {
                MessageBox.Show("Invalid initial!", "Error");
            }
        }

        private void clearEntry()
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
            textBox1.Focus();
        }




        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            string initial = textBox1.Text.Trim();
            double amount;

            if (initial == "" || !double.TryParse(textBox2.Text, out amount) || amount < 0)
            {
                MessageBox.Show("Please enter a valid initial and a positive sale amount.", "Input Error");
                return;
            }




            getSalesPerson_Amount(initial, amount);

            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }




        private void Btn_Clear_Click(object sender, EventArgs e)
        {
            clearEntry();
        }

        private void Btn_Print_Click(object sender, EventArgs e)
        {
            SummaryForm report = new SummaryForm(danielleTotal, edwardTotal, fatimaTotal);
            report.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Btn_Print_Click(sender, e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Btn_Clear_Click(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Btn_Submit_Click(sender, e);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
    }
}
