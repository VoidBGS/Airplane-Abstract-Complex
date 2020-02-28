using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airplane
{
    public partial class FlightInformationForm : Form
    {
        Airplane a;
        AddPassangers add;
        public FlightInformationForm(Airplane a)
        {
            InitializeComponent();
            this.a = a;
            lblFlight.Text = a.Name;
            lblSeat.Text = a.AmountOfTotalSeats.ToString();
            lblBusinessSeat.Text = a.AmountOfBusinessSeats.ToString();
            lblEconomySeats.Text = a.AmountOfEconomySeats.ToString();
            lblPilots.Text = FlightInformation.GetAllPilots(a).Count.ToString();
            lblAttendants.Text = FlightInformation.GetAllAttendants(a).Count.ToString();
            lblPassengerSeats.Text = Convert.ToString(a.GetAllPeople().Count);
            lblBusinessPassangers.Text = Convert.ToString(a.GetAllBusinessPeople().Count.ToString());
            lblEconomyPassangers.Text = Convert.ToString(a.GetAllEconomyPeople().Count.ToString());
        }

        private void FlightInformationForm_Load(object sender, EventArgs e)
        {

        }

        private void BtnGoback_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void BtnPassengers_Click(object sender, EventArgs e)
        {
            lbCreatedPassengers.Items.Clear();
            foreach(Person item in a.GetAllPeople())
            {
                lbCreatedPassengers.Items.Add(item.GetInfo());
            }
        }

        private void BtnEconomy_Click(object sender, EventArgs e)
        {
            lbEconomy.Items.Clear();
            foreach(Seat item in a.GetAllEconomySeats())
            {
                lbEconomy.Items.Add(item.GetInfo());
            }
        }

        private void BtnBusiness_Click(object sender, EventArgs e)
        {
            lbBusiness.Items.Clear();
            foreach (Seat item in a.GetAllBusinessSeats())
            {
                lbBusiness.Items.Add(item.GetInfo());
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            lbCreatedPassengers.Items.Clear();
            if(a.GetAllPeople().Count != 0)
            {
                foreach (Person item in a.GetAllPeople())
                {

                    if (boxPilot.Checked)
                    {
                        if (item is Pilot)
                        {
                            if (boxJunior.Checked)
                            {
                                if (((Pilot)item).GetPosition == Position.JUNIOR)
                                {
                                    lbCreatedPassengers.Items.Add(((Pilot)item).GetInfo());
                                }
                            }
                            if (boxSenior.Checked)
                            {
                                if (((Pilot)item).GetPosition == Position.SENIOR)
                                {
                                    lbCreatedPassengers.Items.Add(((Pilot)item).GetInfo());
                                }
                            }
                            if ((!boxSenior.Checked) && (!boxJunior.Checked))
                            {
                                lbCreatedPassengers.Items.Add(((Pilot)item).GetInfo());
                            }
                        }
                    }
                    if (boxAttendant.Checked)
                    {
                        if (item is Attendant)
                        {
                            if (boxJunior.Checked)
                            {
                                if (((Attendant)item).GetPosition == Position.JUNIOR)
                                {
                                    lbCreatedPassengers.Items.Add(((Attendant)item).GetInfo());
                                }
                            }
                            if (boxSenior.Checked)
                            {
                                if (((Attendant)item).GetPosition == Position.SENIOR)
                                {
                                    lbCreatedPassengers.Items.Add(((Attendant)item).GetInfo());
                                }
                            }
                            if ((!boxSenior.Checked) && (!boxJunior.Checked))
                            {
                                lbCreatedPassengers.Items.Add(((Attendant)item).GetInfo());
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("This Airplane is empty!");
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lbCreatedPassengers.Items.Clear();
                string fName = tbSearchFName.Text;
                string lName = tbSearchLName.Text;
                string name = $"{fName} {lName}";
                Person p = a.GetPerson(name);
                lbCreatedPassengers.Items.Add(p.GetInfo());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure the information provided is correct!");
            }
        }
    }
}
