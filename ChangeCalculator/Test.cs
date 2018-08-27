using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChangeCalculator
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void cmdCalulate_Click(object sender, EventArgs e)
        {
            decimal Amt = 0;
            try
            {
                Amt = decimal.Parse(txtAmount.Text);
                txtChange.Text = ChangeDollars.Change(Amt);
            }
            catch {
                MessageBox.Show("Invalid Amount !!!");
                txtAmount.Focus();
            }
            
            
        }
    }
}
