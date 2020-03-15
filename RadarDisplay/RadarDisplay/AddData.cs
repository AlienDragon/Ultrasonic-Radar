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
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            this.angle = scrAngle.Value;
            this.distance = scrDist.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
