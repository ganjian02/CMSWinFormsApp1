using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp1
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void JobDetailsForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void txtCarNo_Leave(object sender, EventArgs e)
        {
            if ((txtCarNo.Text == "") || (txtCarNo.Text == null))
            {
                MessageBox.Show("Please specify a valid value for the car number", "Error in input");
                txtCarNo.Focus();
            }
        }

        private void bthUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (bthUpdate.Text.Length < 6)
                {
                    MessageBox.Show("Please specify a valid car Number");
                    bthUpdate.Focus();
                    return;
                }
                if (Convert.ToInt32(txtWorkerID.Text) < 1)
                {
                    MessageBox.Show("Please specify a valid worker ID");
                    txtWorkerID.Focus();
                    return;
                }
                if (Convert.ToDateTime(dateTimePicker1.Text) > DateTime.Today)
                {
                    MessageBox.Show("Please specify a valid Date");
                    dateTimePicker1.Focus();
                    return;
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
