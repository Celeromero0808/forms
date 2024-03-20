using System.Diagnostics.Eventing.Reader;

namespace forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnok_Click(object sender, EventArgs e)

        {
            if (txtboxus.Text == "Eduardo" & txtboxcon.Text == "1234") 
            {
                MessageBox.Show("usuario correcto");
            }


            else
            {
                MessageBox.Show("error");
            }



        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtboxus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
