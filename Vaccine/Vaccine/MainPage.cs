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
    public partial class MainPage : Form
    {
        Person CurrentPerson = new Person();
        
        public MainPage(Person currentperson)
        {
            InitializeComponent();
            CurrentPerson = currentperson;
            PersonManager Pmanager = new PersonManager();
        }

        private void btnEditprofile_Click(object sender, EventArgs e)
        {
            EditInformations editpage = new EditInformations(CurrentPerson);
            this.Hide();
            editpage.Show();
        }

        private void btnTakeappointment_Click(object sender, EventArgs e)
        {

        }

        private void btnback_Click(object sender, EventArgs e)
        {
            
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            Take take = new Take(CurrentPerson);
            this.Hide();
            take.Show();

        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();

            this.Hide();
            form1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            label1.Text = $"{CurrentPerson._FullName}     {CurrentPerson._NationalCode}";
            //label1.Text = $"{CurrentPerson._VaccineName}  {CurrentPerson._MyAppointment._VaccinationTime.Year} / {CurrentPerson._MyAppointment._VaccinationTime.Month} / {CurrentPerson._MyAppointment._VaccinationTime.Day}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kryptonButton4_Click(object sender, EventArgs e)
        {
            DeleteAccount deletepage = new DeleteAccount(CurrentPerson);
            this.Hide();
            deletepage.Show();
        }
    }
}
