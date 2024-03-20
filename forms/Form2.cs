using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btncalcular_click(object sender, EventArgs e)
        {
            int v, t;
            float D;
            v = int.Parse(txtboxV.Text);
            t = int.Parse(txtboxT.Text);
            D = v * t;
            lblresul.Text = D.ToString();

        }
    }
}
