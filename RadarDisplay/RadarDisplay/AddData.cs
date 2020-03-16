using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadarDisplay
{
    public partial class AddData : Form
    {
        public float angle;
        public float distance;


        public AddData()
        {
            InitializeComponent();

            tbAngle.Text = scrAngle.Value.ToString();
            tbDist.Text = scrDist.Value.ToString();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.angle = float.Parse(tbAngle.Text);
            this.distance = float.Parse(tbDist.Text);

            if (angle >= 0 && angle <= 180)
            {
                if (distance >= 0 && distance < 201)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    lblError.Text = "Error: Please set 'distance' to a value between 0cm and 200cm (for stability reasons)";
                    lblError.Visible = true;
                }
            }
            else
            {
                lblError.Text = "Error: Please set 'servo angle' to a value between 0 and 180 degrees";
                lblError.Visible = true;
            }
        }

        private void scrAngle_ValueChanged(object sender, EventArgs e)
        {
            tbAngle.Text = scrAngle.Value.ToString();
        }

        private void scrDist_ValueChanged(object sender, EventArgs e)
        {
            tbDist.Text = scrDist.Value.ToString();
        }

        private void tbDist_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void tbAngle_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
