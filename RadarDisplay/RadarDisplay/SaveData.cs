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
    public partial class SaveData : Form
    {
        public string fileName;


        public SaveData()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.fileName = tbName.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void tbName_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
