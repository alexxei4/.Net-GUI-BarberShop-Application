using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabTwoB
{
    ///I, Alexei Ougriniouk, 000776331 certify that this material is my original work.No other person's work has been used without due acknowledgement.
    public partial class Form1 : Form
    {
        public static BarbPrices barberprices = new BarbPrices();
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            clientnumeric.Value = 0;
            
        }
        /// <summary>
        /// Adds the fee based on what Hairdresser is picked
        /// </summary>
        /// <returns>HairDresserFee</returns>
        private decimal HairdresserPrice()
        {
            decimal HairdresserFee;
            if (JaneSamley.Checked)
                HairdresserFee = 30;
            else if (PatJohnson.Checked)
                HairdresserFee = 45;
            else if (RonChambers.Checked)
                HairdresserFee = 40;
            else if (SuePallon.Checked)
                HairdresserFee = 50;
            else if (LauraRenkins.Checked)
                HairdresserFee = 55;
            else
                HairdresserFee = 0;
            return HairdresserFee;
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }
       /// <summary>
       /// Calculates the Service Costs
       /// </summary>
       /// <returns>servicecosts</returns>
        private decimal ServiceCosts()
        {
            decimal ServiceC = 0;
            if (Cut.Checked)
                ServiceC += 30;
            if (Colour.Checked)
                ServiceC += 40;
            if (Highlights.Checked)
                ServiceC += 50;
            if (Extensions.Checked)
                ServiceC += 200;
            else
                ServiceC += 0;
            return ServiceC;
        }
        /// <summary>
        ///  This calculates the Client Discount Costs
        /// </summary>
        /// <returns>ClientD</returns>

        private decimal ClientCosts()
        {
            decimal ClientD ;
            if (Standard.Checked)
                ClientD = 0;
            else if (LilKid.Checked)
                ClientD = 0.10m;
            else if (Student.Checked)
                ClientD = 0.05m;
            else if (Elderly.Checked)
                ClientD = 0.15m;
            else
                ClientD = 0;
            return ClientD;
        }
        private decimal visitspackage()
        {

            int CNT = Convert.ToInt32(Math.Round(clientnumeric.Value, 0));
            decimal VisDCount;
            if (CNT > 0 && CNT < 4)
            {
                VisDCount = 0;
            }
            else if (CNT > 3 && CNT < 9)
            {
                VisDCount = 0.05m;
            }
            else if (CNT > 8 && CNT < 14)
            {
                VisDCount = 0.10m;
            }
            else if (CNT > 14)
            {
                VisDCount = 0.15m;
            }
            else
                VisDCount = 0;

            return VisDCount;
        }

        private void Calculate_Click(object sender, EventArgs e)

        {
            barberprices = new BarbPrices(ServiceCosts(), ClientCosts(), visitspackage(), HairdresserPrice());
            textBox1.Text = barberprices.haircutcosts().ToString();
        }


        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
