using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Try4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
            private void btnSave_Click(object sender, EventArgs e)
        {
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string age = txtAge.Text;
            string registrationDate = dtpRegistrationDate.Value.ToString("yyyy-MM-dd");
            bool hasTeam = chkHasTeam.Checked;

            string registrationData = $"{firstName};{lastName};{phoneNumber};{age};{registrationDate};{hasTeam}";

            // Сохранение данных в текстовый файл
            using (StreamWriter writer = new StreamWriter("registrations.txt", true))
            {
                writer.WriteLine(registrationData);
            }

            MessageBox.Show("Данные успешно сохранены!");

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void chkHasTeam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

