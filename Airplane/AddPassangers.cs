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
    public partial class AddPassangers : Form
    {
        Airplane a;
        GenerateName generate;
        Random randomness = new Random();
        AirControl ac;

        public AddPassangers(Airplane a, AirControl ac)
        {
            InitializeComponent();
            this.ac = ac;
            lblPlane.Text = a.Name;
            this.a = a;
            generate = new GenerateName();
        }

        private void AddPassangers_Load(object sender, EventArgs e)
        {

        }

        private void BtnAddPassanger_Click(object sender, EventArgs e)
        {
            try
            {
                int amount = Convert.ToInt32(tbAmount.Text);
                int businessAmount = Convert.ToInt32(tbBusinessAmount.Text);
                if ((FlightInformation.GetAllPilots(a).Count == 2 || FlightInformation.GetAllPilots(a).Count == 4) && FlightInformation.GetAllAttendants(a).Count == 6)
                {
                    if (a.InUse == false)
                    {
                        if (amount <= a.AmountOfEconomySeats && businessAmount <= a.AmountOfBusinessSeats)
                        {
                            a.GetAllEconomySeats().Clear();
                            a.GetAllBusinessSeats().Clear();
                            generate.GenerateNames();
                            for (int i = 1; i <= amount; i++)
                            {
                                int randomFirstName = randomness.Next(50);
                                int randomLastName = randomness.Next(50);
                                int randomAge = randomness.Next(1, 90);
                                a.AddPerson(new Passenger(generate.FirstName()[randomFirstName], generate.LastName()[randomLastName], randomAge));

                            }
                            for (int i = 1; i <= businessAmount; i++)
                            {
                                int randomFirstName = randomness.Next(50);
                                int randomLastName = randomness.Next(50);
                                int randomAge = randomness.Next(1, 90);
                                a.AddPersonBusiness(new Passenger(generate.FirstName()[randomFirstName], generate.LastName()[randomLastName], randomAge));

                            }
                            a.AssignSeatsEconomy();
                            a.AssignSeatsBusiness();
                            a.CommenceFlight();
    

                        }
                        else
                        {
                            MessageBox.Show("Maximum seats for business class: " + a.AmountOfBusinessSeats + "\n" +
                                "Maximum seats for economy class:" + a.AmountOfEconomySeats);
                        }
                    }
                    else
                    {
                        MessageBox.Show("This airplane is already in use!");
                    }
                }
                else
                {
                    MessageBox.Show("Pilots must be between 2 or 4!" + "\n" + "Attendants must be 6!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure the information provided is correct!");
            }

            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lbCreatedPassangers.Items.Clear();
            foreach(Person p in a.GetAllPeople())
            {
                lbCreatedPassangers.Items.Add(p.GetInfo());
            }
        }

        private void BtnGoback_Click(object sender, EventArgs e)
        {
            ac.Visible = true;
            this.Close();
        }

        private void BtnAddMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (a.InUse == false)
                {
                    string fName = tbFirstName.Text;
                    string lName = tbLastName.Text;
                    int age = Convert.ToInt32(tbAge.Text);
                    string position = cbPosition.Text;
                    if (a.GetPerson($"{fName} {lName}") == null)
                    {
                        if (rbSenior.Checked)
                        {
                            if (position == "PILOT")
                            {
                                a.AddPersonEmployee(new Pilot(fName, lName, age, Position.SENIOR));
                            }
                            else if (position == "ATTENDANT")
                            {
                                a.AddPersonEmployee(new Attendant(fName, lName, age, Position.SENIOR));
                            }
                        }
                        else if (rbJunior.Checked)
                        {
                            if (position == "PILOT")
                            {
                                a.AddPersonEmployee(new Pilot(fName, lName, age, Position.JUNIOR));
                            }
                            else if (position == "ATTENDANT")
                            {
                                a.AddPersonEmployee(new Attendant(fName, lName, age, Position.JUNIOR));
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("You cannot have people with the same name!");
                    }
                }
                else
                {
                    MessageBox.Show("This airplane is already in use!");
                }
            }
 
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure the information provided is correct!");
            }
        }

        private void BtnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string fName = tbSearchFName.Text;
                string lName = tbSearchLName.Text;
                string name = $"{fName} {lName}";
                a.RemovePerson(name);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure the information provided is correct!");
            }
        }

        private void BtnFilter_Click(object sender, EventArgs e)
        {
            lbCreatedPassangers.Items.Clear();
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
                                lbCreatedPassangers.Items.Add(((Pilot)item).GetInfo());
                            }
                        }
                        if (boxSenior.Checked)
                        {
                            if (((Pilot)item).GetPosition == Position.SENIOR)
                            {
                                lbCreatedPassangers.Items.Add(((Pilot)item).GetInfo());
                            }
                        }
                        if ((!boxSenior.Checked) && (!boxJunior.Checked))
                        {
                            lbCreatedPassangers.Items.Add(((Pilot)item).GetInfo());
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
                                lbCreatedPassangers.Items.Add(((Attendant)item).GetInfo());
                            }
                        }
                        if (boxSenior.Checked)
                        {
                            if (((Attendant)item).GetPosition == Position.SENIOR)
                            {
                                lbCreatedPassangers.Items.Add(((Attendant)item).GetInfo());
                            }
                        }
                        if ((!boxSenior.Checked) && (!boxJunior.Checked))
                        {
                            lbCreatedPassangers.Items.Add(((Attendant)item).GetInfo());
                        }
                    }
                }
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                lbCreatedPassangers.Items.Clear();
                string fName = tbSearchFName.Text;
                string lName = tbSearchLName.Text;
                string name = $"{fName} {lName}";
                Person p = a.GetPerson(name);
                lbCreatedPassangers.Items.Add(p.GetInfo());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please make sure the information provided is correct!");
            }
        }
    }
    }

