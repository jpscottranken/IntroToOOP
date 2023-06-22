using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPProject01
{
    public partial class frmOOPProject01 : Form
    {
        public frmOOPProject01()
        {
            InitializeComponent();
        }

        private void btnGreeting_Click(object sender, EventArgs e)
        {
            //  Checking for presence of abscence of a name
            //  in the textName textbox.
            if (txtName.Text.Trim() == "")
            {       //  Name textbox is emptyl.
                MessageBox.Show("Please Enter A Name",
                                "NO NAME INPUT",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                txtName.Focus();
                return;
            }

            MessageBox.Show("Hello " + txtName.Text,
                "NAME WAS INPUT",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void frmOOPProject01_Load(object sender, EventArgs e)
        {
            btnGreeting.BackColor = Color.Black;
            btnGreeting.ForeColor = Color.White;
        }
    }
}
