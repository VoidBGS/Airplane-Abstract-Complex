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
    public partial class PlaneCreation : Form
    {
        AirControl ac;
        public PlaneCreation(AirControl ac)
        {
            InitializeComponent();
            this.ac = ac;
        }

        private void BtnGoback_Click(object sender, EventArgs e)
        {
            ac.Visible = true;
            this.Close();
        }

        private void PlaneCreation_Load(object sender, EventArgs e)
        {

        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            string type = tbType.Text;
            double business = Convert.ToDouble(nmBusiness.Value);
            int economy = Convert.ToInt32(nmEconomy.Value);
            int businessPerc = Convert.ToInt32(business + (business / 100 * 40)); 
            if (FlightInformation.GetPlane(type) == null)
            {
                if ((economy >= 20)&&(economy > businessPerc))
                {
                    FlightInformation.AddCustomPlane(new Airplane(economy, Convert.ToInt32(business), type));
                }
                else
                {
                    MessageBox.Show("Economy seats must be at least 20" + "\n" + "Business seats must be 40% less than economy seats");
                }
            }
            else
            {
                MessageBox.Show("This airplane type already exists!");
            }
        }
    }
}
