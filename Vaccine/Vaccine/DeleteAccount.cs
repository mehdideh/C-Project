using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vaccine.Class;
namespace Vaccine
{
    public partial class DeleteAccount : Form
    {
        PersonManager Pmanager = new PersonManager();
        Person CurrentPerson = new Person();
        int VerificationCode;
        public DeleteAccount(Person per)
        {
            CurrentPerson = per;
            InitializeComponent();
            btnDelete.Visible = false;
            txtCode.Visible = false;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
           

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            VerificationCode = random.Next();
            string Body = VerificationCode + "";
            string Subject = "Enter Code :)";

            Email email = new Email();
            email.SendEmail(CurrentPerson._Email, Subject, Body);

            MessageBox.Show("Email sent successfully !");
            btnDelete.Visible = true;
            txtCode.Visible = true;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (VerificationCode.ToString() == txtCode.Text)
            {
                Pmanager.RemovePersonbyNationalCode(CurrentPerson._NationalCode);
                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            else
            {
                MessageBox.Show("incorrect Code");
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(CurrentPerson);
            this.Hide();
            mainpage.Show();
        }

        private void DeleteAccount_Load(object sender, EventArgs e)
        {

        }
    }
}
