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
    public partial class EditInformations : Form
    {
        Person CurrentPerson = new Person();
        
        public EditInformations(Person currentperson)
        {
            CurrentPerson = currentperson;
            InitializeComponent();
            btnEdit.Visible = false;
            txtNewPass.Visible = false;
            txtConfirmPass.Visible = false;
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // PersonManager PManager = new PersonManager();
            if (CurrentPerson._Password == txtPassword.Text)
            {
                btnEdit.Visible = true;
                txtNewPass.Visible = true;
                txtConfirmPass.Visible = true;

            }
            else
            {
                MessageBox.Show("Password is not Match");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtConfirmPass.Text == txtNewPass.Text)
            {
                PersonManager pmanager = new PersonManager();
                CurrentPerson._Password = txtNewPass.Text;
                CurrentPerson._Email = txtEmail.Text;
                pmanager.UpdatePersonData(CurrentPerson._NationalCode, CurrentPerson);

                MessageBox.Show("Profile Edited ");
            }
            else
            {
                MessageBox.Show("Password is not Match");
            }
        }

        private void btnback_Click(object sender, EventArgs e)
        {
            //MainPage main = new MainPage();
            //this.Hide();
            //main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            MainPage mainpage = new MainPage(CurrentPerson);
            this.Hide();
            mainpage.Show();
        }
    }
}
