using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using Vaccine.Class;

namespace Vaccine
{
    public partial class SignUp : Form
    {
        int VerificationCode;
        public SignUp()
        {
            InitializeComponent();
            txtConfirmEmail.Visible = false;
            btnConfirmEmail.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text != "" && txtFullname.Text != "" && txtPassword.Text != "" && txtNationalCode.Text != "")
            {
                if (txtPassword.Text == txtConfirmPass.Text)
                {
                    Random random = new Random();
                    VerificationCode = random.Next();
                    string Body = "Hello " + txtFullname.Text + " " + "Your Verification Code is : " + VerificationCode;
                    string Subject= "Verify Your Vaccine Management Account";

                    Email email = new Email();
                    email.SendEmail(txtEmail.Text, Subject, Body);

                    MessageBox.Show("Email sent successfully !");
                    txtConfirmEmail.Visible = true;
                    btnConfirmEmail.Visible = true;
                }
                else MessageBox.Show("Password doesnt match !");
            }
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnConfirmEmail_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtConfirmEmail.Text) == VerificationCode)
            {
                //// Add new Peson to List Pepole
                string name = txtFullname.Text;
                string nationalcode = txtNationalCode.Text;
                string email = txtEmail.Text;
                string password = txtPassword.Text;

                Person NewPerson = new Person(name, nationalcode, email, password);
                PersonManager PManager = new PersonManager();
                PManager.AddNewPerson(NewPerson);
                ////
                ///

                MessageBox.Show("Signed Up Successfully");
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();

            }
            else
            {
                MessageBox.Show("Verification Code is not Correct !");
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Form1 form1page = new Form1();
            this.Hide();
            form1page.Show();
        }
    }
}
