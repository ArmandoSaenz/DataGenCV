using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGenCV.Utities
{
    public partial class State : Form
    {
        public State()
        {
            InitializeComponent();
        }
        public void SetMessage(string msg)
        {
            this.lMessage.Text = msg;
        }
    }
}
