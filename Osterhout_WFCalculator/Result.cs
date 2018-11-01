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
    public partial class Result : Form
    {
        ResultInfo _resultInfo;
        double _result;

        public Result(double result)
        {
            //_resultInfo = resultInfo;
            _result = result;
            InitializeComponent();
        }

        public void Result_Load()
        {

            //lbl_NumberOfPeople.Text = _solutionFormInfo.NumberOfPeople.ToString();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        private void Result_Load(object sender, EventArgs e)
        {
            label2.Text = _result.ToString();
        }
    }
}
