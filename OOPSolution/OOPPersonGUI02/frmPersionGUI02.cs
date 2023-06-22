using System;
using System.Globalization;
using System.Runtime.InteropServices.ComTypes;
using System.Windows.Forms;

namespace OOPPersonGUI02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //  Global arrays
        string[] gender        = { "Female", "Male", "Other" };

        //  Global constants
        const int MINHEIGHT =  12;
        const int MAXHEIGHT =  96;
        const int MINWEIGHT =   1;
        const int MAXWEIGHT = 777;

        //  Global variables
        int height;
        int weight;

        private void btnInstantiate_Click(object sender, EventArgs e)
        {
            CreateNewPersonObject();
        }

        private void CreateNewPersonObject()
        {
            string msg = "";

            try
            {
                if (IsValidData())
                {
                    height = Convert.ToInt32(txtHeight.Text);
                    weight = Convert.ToInt32(txtWeight.Text);

                    Person person = new Person();

                    person.FirstName        = txtFirstName.Text;
                    person.LastName         = txtLastName.Text;
                    person.EyeColor         = txtEyeColor.Text;
                    person.HairColor        = txtHairColor.Text;
                    person.Height           = height;
                    person.Weight           = weight;
                    person.Gender           = txtGender.Text;
                    person.MaritalStatus    = true;

                    MessageBox.Show("Name: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(person.FirstName) + " " + 
                                               CultureInfo.CurrentCulture.TextInfo.ToTitleCase(person.LastName)  +
                                  "\nEye Color: "  + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(person.EyeColor)  +
                                  "\nHair Color: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(person.HairColor) +
                                  "\nHeight: "     + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(person.Height.ToString()) + " inches " +
                                  "\nWeight: "     + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(person.Weight.ToString()) + " pounds " +
                                  "\nGender: "     + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(person.Gender)   +
                                  "\nMarital Status: " + CultureInfo.CurrentCulture.TextInfo.ToTitleCase(person.MaritalStatus.ToString()),
                                    "HERE IS YOUR PERSON",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                ShowMessage($"{msg}\n{ex.Message}\n\n",
                            "ERROR MESSAGES");
            }
        }

        private bool IsValidData()
        {
            string errorMessage = "";

            // Validate the firstName text box is not empty
            errorMessage += IsPresent(txtFirstName.Text, "First Name", txtFirstName);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the lastName text box is not empty
            errorMessage += IsPresent(txtLastName.Text, "Last Name", txtLastName);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the eyeColor textbox is not empty
            errorMessage += IsPresent(txtEyeColor.Text, "Eye Color", txtEyeColor);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the hairColor textbox is not empty
            errorMessage += IsPresent(txtHairColor.Text, "Hair Color", txtHairColor);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the height textbox is not empty
            errorMessage += IsPresent(txtHeight.Text, "Height", txtHeight);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            //  Validate height is within range
            errorMessage += IsWithinRange(txtHeight.Text, "Height", 
                                          MINHEIGHT, MAXHEIGHT, txtHeight);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the weight textbox is not empty
            errorMessage += IsPresent(txtWeight.Text, "Weight", txtWeight);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            //  Validate weight is within range
            errorMessage += IsWithinRange(txtWeight.Text, "Weight",
                                          MINWEIGHT, MAXWEIGHT, txtWeight);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            // Validate the gender textbox is not empty
            errorMessage += IsPresent(txtGender.Text, "Gender", txtGender);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            if ((txtGender.Text.ToUpper() != gender[0].ToUpper()) &&
                (txtGender.Text.ToUpper() != gender[1].ToUpper()) &&
                (txtGender.Text.ToUpper() != gender[2].ToUpper()))
            {
                ShowMessage("Illegal Gender Input. Resetting to Female (default)",
                            "ILLEGAL GENDER");
                txtGender.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(
                                gender[0]);
                
            }

            if ((txtMaritalStatus.Text.ToUpper() != "TRUE") &&
                (txtMaritalStatus.Text.ToUpper() != "FALSE"))
            {
                ShowMessage("Illegal Marital Input. Resetting to True (default)",
                            "ILLEGAL GENDER");
                txtMaritalStatus.Text = "True";
            }

            // Validate the maritalStatus textbox is not empty
            errorMessage += IsPresent(txtMaritalStatus.Text, "Marital Status",
                                      txtMaritalStatus);

            if (errorMessage != "")
            {
                ShowMessage($"{errorMessage}",
                            "ERROR MESSAGES");
                return false;
            }

            return true;
        }

        private void ClearAndFocusCorrectControl(Control ctrl)
        {
            ctrl.Text = "";
            ctrl.Focus();
        }

        private string IsPresent(string value, string name, Control ctrl)
        {
            string msg = "";
            if (value.Trim() == "")
            {
                msg = name + " is a required field.\n";
                ClearAndFocusCorrectControl(ctrl);
            }

            return msg;
        }

        private string IsInt32(string value, string name, Control ctrl)
        {
            string msg = "";
            if (!Int32.TryParse(value, out _))
            {
                msg = name + " must be a valid integer value.\n";
                ClearAndFocusCorrectControl(ctrl);
            }

            return msg;
        }

        private string IsWithinRange(string value, string name,
                                     int min, int max, Control ctrl)
        {
            int number;
            string msg = "";

            if (!Int32.TryParse(value, out number))
            {
                if ((number < min) || (number > max))
                {
                    msg = name + " must be between " + min + " and " + max + ".\n";
                    ClearAndFocusCorrectControl(ctrl);
                }
            }

            return msg;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEyeColor.Text = "";
            txtHairColor.Text = "";
            txtHeight.Text = "";
            txtWeight.Text = "";
            txtGender.Text = "";
            txtMaritalStatus.Text = "";
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
