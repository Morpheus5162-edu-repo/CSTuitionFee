using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTutitionFee
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            int tuitionFee;

            bool isTuitionFeeValid = int.TryParse(Txttuitionfee.Text, out tuitionFee);

            if(!isTuitionFeeValid)
            {
                MessageBox.Show("Please Enter Integers Only.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double tuitionFeeDouble = tuitionFee;

            if (Rdcash.Checked)
            {
                tuitionFeeDouble -= tuitionFeeDouble * 0.10;
            }
            else if (Rdtwopayments.Checked)
            {
                tuitionFeeDouble += tuitionFeeDouble * 0.05;
            }
            else if (Rdthreepayments.Checked)
            {
                tuitionFeeDouble += tuitionFeeDouble * 0.10;
            }

            Txttotal.Text = tuitionFeeDouble.ToString("C2");
        }
    }
}
