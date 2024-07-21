using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGenCV.Views
{
    public partial class FrmPosture : Form
    {
        public double Distance => double.Parse(tbDistance.Text);
        public double Angle => double.Parse(tbAngle.Text);
        public FrmPosture()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
