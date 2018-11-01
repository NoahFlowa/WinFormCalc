using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Osterhout_WFCalculator
{
    public partial class CalculatorForm : Form
    {

        public CalculatorForm()
        {
            InitializeComponent();
        }

        public void CalculatorForm_Load(object sender, EventArgs e)
        {
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            //Result resultForm = new Result(new ResultInfo());
            //resultForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            //resultForm.MinimizeBox = false;
            //resultForm.MaximizeBox = false;
            //resultForm.ShowDialog();
            //resultForm.Dispose();

            //ResultInfo resultInfo = new ResultInfo();

            double value1;
            double value2;
            double result = 0;

            if (textBox1.Text == null)
            {
                MessageBox.Show("Failed to read Value 1's value.\n This application will now close.");
                this.Close();
            }

            if (textBox2.Text == null)
            {
                MessageBox.Show("Failed to read Value 2's value.\n This application will now close.");
                this.Close();
            }

            Double.TryParse(textBox1.Text, out value1);
            Double.TryParse(textBox2.Text, out value2);

            if (add_radio.Checked == true)
            {
                result = value1 + value2;
                //MessageBox.Show("Answer: " + result.ToString());
                //resultInfo.theResult = result;
            }
            else if (sub_radio.Checked == true)
            {
                result = value1 - value2;
                MessageBox.Show("Answer: " + result.ToString());
                //label2.Text = "Answer: " + result.ToString();
            }
            else if (mult_radio.Checked == true)
            {
                result = value1 * value2;
                MessageBox.Show("Answer: " + result.ToString());
                //label2.Text = "Answer: " + result.ToString();
            }
            else if (divide_radio.Checked == true)
            {
                result = value1 / value2;
                MessageBox.Show("Answer: " + result.ToString());
                //label2.Text = "Answer: " + result.ToString();
            }

            Result resultForm = new Result(result);
            resultForm.ShowDialog();
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void help_btn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Enter your first number in Value 1 box and second number in Value 2 box.  Then choose a calculation method");
            Help helpForm = new Help();
            helpForm.FormBorderStyle = FormBorderStyle.FixedDialog;
            helpForm.MinimizeBox = false;
            helpForm.MaximizeBox = false;
            helpForm.ShowDialog();
            helpForm.Dispose();
        }
    }
}
