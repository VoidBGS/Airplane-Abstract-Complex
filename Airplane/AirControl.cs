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

    public partial class AirControl : Form
    {
        AddPassangers ap;
        public AirControl()
        {
            InitializeComponent();
        }

        #region Common Methods
        private List<string>letters()
        {
            int id = Convert.ToInt32(tbSearchID.Text);

            Airplane a = FlightInformation.GetAirplaneInfo(id);
            List<string> test = new List<string>();
            for (int i = 0; i <= a.AmountOfEconomySeats; i++)
            {
                test.Add("A");
                test.Add("B");
                test.Add("C");
                test.Add("D");
                test.Add("E");
                test.Add("F");
            }
            return test;
        }
        private List<string> lettersTwo()
        {
            int id = Convert.ToInt32(tbSearchID.Text);

            Airplane a = FlightInformation.GetAirplaneInfo(id);
            List<string> test = new List<string>();
            for (int i = 0; i <= a.AmountOfBusinessSeats; i++)
            {
                test.Add("A");
                test.Add("B");
            }
            return test;
        }


        #endregion

        private void TbSearchAirplane_Click_1(object sender, EventArgs e)
        {
            try
            {
                lbCreatedAriplanes.Items.Clear();
                int id = Convert.ToInt32(tbSearchID.Text);
                Airplane a = FlightInformation.GetAirplaneInfo(id);
                lbCreatedAriplanes.Items.Add(a.GetInfoInUse());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure the information is correct!");
            }
        }

        private void BtnFlightInformation_Click_1(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbSearchID.Text);
                Airplane a = FlightInformation.GetAirplaneInfo(id);
                FlightInformationForm info = new FlightInformationForm(a);
                info.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure the information is correct!");
            }
        }

        private void BtnAddPassengers_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbSearchID.Text);

                Airplane a = FlightInformation.GetAirplaneInfo(id);

                if (a.InUse == false)
                {
                    for (int i = 1; i <= a.AmountOfBusinessSeats; i++)
                    {
                        a.AddBusinessSeat(new Seat($"{i}{lettersTwo()[i]}"));
                    }
                    for (int i = 1; i <= a.AmountOfEconomySeats; i++)
                    {
                        a.AddEconomySeat(new Seat($"{i}{letters()[i]}"));
                    }
                    ap = new AddPassangers(a, this);
                    this.Visible = false;
                    ap.Show();
                }
                else
                {
                    MessageBox.Show("This airplane is already in use!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please make sure the information is correct!");
            }
        }

        private void BtnCreateFlight_Click_1(object sender, EventArgs e)
        {
            string type = cbPlaneType.Text;
            Airplane custom = FlightInformation.GetPlane(type);
            switch (cbPlaneType.SelectedItem)
            {
                case "Dornier 328": FlightInformation.AddInformation(new Airplane(type, 25, 5)); break;
                case "Boeing 737": FlightInformation.AddInformation(new Airplane(type, 180, 20)); break;
                case "Boeing 767": FlightInformation.AddInformation(new Airplane(type, 360, 40)); break;
                case "Boeing 747-8": FlightInformation.AddInformation(new Airplane(type, 400, 60)); break;
                case "Airbus A380": FlightInformation.AddInformation(new Airplane(type, 700, 150)); break;
                default:
                        if(cbPlaneType.SelectedItem.ToString() == custom.Type)
                        {
                            FlightInformation.AddInformation(new Airplane(custom.Type, custom.AmountOfEconomySeats, custom.AmountOfBusinessSeats));
                        }
                    
                    break;

            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            lbCreatedAriplanes.Items.Clear();
            foreach (Airplane a in FlightInformation.GetInformation())
            {
                if (a.InUse == false)
                {
                    lbCreatedAriplanes.Items.Add(a.GetInfoCreated());
                }
                else
                {
                    lbCreatedAriplanes.Items.Add(a.GetInfoInUse());
                }
            }
        }

        private void BtnCreateCustom_Click(object sender, EventArgs e)
        {
            PlaneCreation pc = new PlaneCreation(this);
            this.Visible = false;
            pc.Show();
        }

        private void CbPlaneType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CbPlaneType_SizeChanged(object sender, EventArgs e)
        {

        }

        private void CbPlaneType_Click(object sender, EventArgs e)
        {
            foreach (Airplane a in FlightInformation.GetCustomPlanes())
            {
                while(!cbPlaneType.Items.Contains(a.Type))
                {
                    cbPlaneType.Items.Add(a.Type);
                }
         
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbSearchID.Text);
            Airplane a = FlightInformation.GetAirplaneInfo(id);
            if (a.InUse == false)
            {
                FlightInformation.RemoveAirplane(id);
            }
            else
            {
                MessageBox.Show("Tou cannot remove an airplane that is in use!");
            }
        }
    }
}
