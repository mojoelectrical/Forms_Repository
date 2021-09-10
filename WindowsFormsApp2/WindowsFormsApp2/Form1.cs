using SwimManagementSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        ClubsManager clubager;
        SwimmersManager swimager;
        BindingSource swimmerBind = new BindingSource();
        BindingSource clubBind = new BindingSource();
        
        public Form1()
        {
            InitializeComponent();
            clubager = new ClubsManager();
            swimager = new SwimmersManager(clubager);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DisplayView.Items.Clear();
            string match =clubListBox.GetItemText(clubListBox.SelectedItem);
            Club showit = (Club) clubListBox.SelectedItem;
            DisplayView.Items.Add(showit.Name);
            DisplayView.Items.Add(Convert.ToString(showit.PhoneNumber));
            DisplayView.Items.Add(showit.ClubAddress.Street);
            DisplayView.Items.Add(showit.ClubAddress.City);
            DisplayView.Items.Add(showit.ClubAddress.Province);
            DisplayView.Items.Add(showit.ClubAddress.PostalCode);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void swimmerAddBtn_Click(object sender, EventArgs e)
        {
            Address newaddress = new Address(swimmerNameTB.Text, swimmerCityTB.Text, swimmerProvinceTB.Text, swimmerPCodeTB.Text);

            Swimmer newSwimmer = new Swimmer(swimmerNameTB.Text, DateTime.Parse(swimmerDOBTB.Text), newaddress, ulong.Parse(swimmerPhoneTB.Text));
            //adds swimmer

            swimmerBind.DataSource = swimager.Swimmers;
            swimmerListBox.DataSource = swimmerBind;
            swimager.AddSwimmer(newSwimmer);
            swimmerListBox.DisplayMember = "Name";
            swimmerBind.ResetBindings(false);
        }

        private void clubAddBtn_Click(object sender, EventArgs e)
        {
            Address clubaddress = new Address(clubNameTB.Text, clubCityTB.Text, clubProvinceTB.Text, clubPCodeTB.Text);
            Club clubA = new Club(clubNameTB.Text, clubaddress, ulong.Parse(clubPhoneTB.Text));

            clubBind.DataSource = clubager.Clubs;
            clubListBox.DataSource = clubBind;

            clubager.AddClub(clubA);

            clubListBox.DisplayMember = "Name";
            clubBind.ResetBindings(false);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void swimmerListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayView.Items.Clear();
            string match = swimmerListBox.GetItemText(swimmerListBox.SelectedItem);
            Swimmer showit = (Swimmer)swimmerListBox.SelectedItem;
            DisplayView.Items.Add(showit.Name);
            DisplayView.Items.Add(showit.DateOfBirth.ToString());
            DisplayView.Items.Add(Convert.ToString(showit.PhoneNumber));
            DisplayView.Items.Add(showit.Address.Street);
            DisplayView.Items.Add(showit.Address.City);
            DisplayView.Items.Add(showit.Address.Province);
            DisplayView.Items.Add(showit.Address.PostalCode);

        }
    }
}
