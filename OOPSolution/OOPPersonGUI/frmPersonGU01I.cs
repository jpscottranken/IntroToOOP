using System;
using System.Windows.Forms;

namespace OOPPersonGUI
{
    public partial class frmPersonGU01I : Form
    {
        public frmPersonGU01I()
        {
            InitializeComponent();
        }

        int height;
        int weight;

        private void btnInstantiate_Click(object sender, EventArgs e)
        {
            CreateNewPersonObject();
        }

        private void CreateNewPersonObject()
        {
            bool keepGoing = AddFirstName();

            if (keepGoing)
            {
                keepGoing = AddLastName();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = AddEyeColor();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = AddHairColor();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                height = Int32.Parse(txtHeight.Text);
                keepGoing = AddHeight();
            }
            else 
            {
                return;
            }

            if (keepGoing)
            {
                weight = Int32.Parse(txtWeight.Text);
                keepGoing = AddWeight();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = AddGender();
            }
            else
            {
                return;
            }

            if (keepGoing)
            {
                keepGoing = AddMaritalStatus();
            }
            else
            {
                return;
            }

            //  Instantiate the person object
            Person person = new Person();

            person.FirstName     = txtFirstName.Text;
            person.LastName      = txtLastName.Text;
            person.EyeColor      = txtEyeColor.Text;
            person.HairColor     = txtHairColor.Text;
            person.Height        = height;
            person.Weight        = weight;
            person.Gender        = txtGender.Text;
            person.MaritalStatus = true;

            MessageBox.Show("Here is your person: " +
                            "\nName: " + person.FirstName + " " + person.LastName +
                            "\nEye Color: " + person.EyeColor + 
                            "\nHair Color: " + person.HairColor +
                            "\nHeight: " + person.Height.ToString() + 
                            "\nWeight: " + person.Weight.ToString() +
                            "\nGender: " + person.Gender +
                            "\nMarital Status: " + person.MaritalStatus,
                            "HERE IS YOUR PERSON",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private bool AddFirstName()
        {
            bool retVal = true;

            if (txtFirstName.Text.Trim() == "")
            {
                ShowMessage("First Name Cannot Be Blank",
                            "BLANK FIRST NAME");
                txtFirstName.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool AddLastName()
        {
            bool retVal = true;

            if (txtLastName.Text.Trim() == "")
            {
                ShowMessage("Last Name Cannot Be Blank",
                            "BLANK LAST NAME");
                txtLastName.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool AddEyeColor()
        {
            bool retVal = true;

            if (txtEyeColor.Text.Trim() == "")
            {
                ShowMessage("Eye Color Cannot Be Blank",
                            "BLANK EYE COLOR");
                txtEyeColor.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool AddHairColor()
        {
            bool retVal = true;

            if (txtHairColor.Text.Trim() == "")
            {
                ShowMessage("Hair Color Cannot Be Blank",
                            "BLANK HAIR COLOR");
                txtEyeColor.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool AddHeight()
        {
            bool retVal = true;

            if (txtHeight.Text.Trim() == "")
            {
                ShowMessage("Height Cannot Be Blank",
                            "BLANK HEIGHT");
                txtHeight.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool AddWeight()
        {
            bool retVal = true;

            if (txtWeight.Text.Trim() == "")
            {
                ShowMessage("Weight Cannot Be Blank",
                            "BLANK WEIGHT");
                txtHeight.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool AddGender()
        {
            bool retVal = true;

            if (txtGender.Text.Trim() == "")
            {
                ShowMessage("Gender Cannot Be Blank",
                            "BLANK Gender");
                txtGender.Focus();
                retVal = false;
            }

            return retVal;
        }

        private bool AddMaritalStatus()
        {
            bool retVal = true;

            if (txtMaritalStatus.Text.Trim() == "")
            {
                ShowMessage("Marital Status Cannot Be Blank",
                            "BLANK MARITAL STATUS");
                txtMaritalStatus.Focus();
                retVal = false;
            }

            return retVal;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtFirstName.Text       = "";
            txtLastName.Text        = "";
            txtEyeColor.Text        = "";
            txtHairColor.Text       = "";
            txtHeight.Text          = "";
            txtWeight.Text          = "";
            txtGender.Text          = "";
            txtMaritalStatus.Text   = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
        {
            DialogResult dialog = MessageBox.Show(
                               "Do You Really Want To Exit?",
                               "EXIT NOW?",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Close();
            }
        }

        private void ShowMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }
    }
}
