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
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Person CurrentPerson = new Person();
            PersonManager Pmanager = new PersonManager();
            //MessageBox.Show(Pmanager.FindPerson(txtNationalCode.Text, txtPassword.Text)._MyAppointment._VaccinationTime.ToString());
            CurrentPerson = Pmanager.FindPerson(txtNationalCode.Text, txtPassword.Text);
            if (Pmanager.isPersonExist)
            {

                MainPage mainpage = new MainPage(CurrentPerson);
                this.Hide();
                mainpage.Show();
            }
            else
            {
                MessageBox.Show("User Doesnt Exist !");
            }


        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignUp signup = new SignUp();
            this.Hide();
            signup.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PersonManager pmanager = new PersonManager();
            
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Person CurrentPerson = new Person();
            PersonManager Pmanager = new PersonManager();
            CurrentPerson = Pmanager.FindPerson(txtNationalCode.Text, txtPassword.Text);
            EditInformations editpage = new EditInformations(CurrentPerson);
            
            this.Hide();
            editpage.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
