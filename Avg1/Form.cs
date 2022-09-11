using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Avg1
{
    public partial class average : Form
    {
        //Declare Variables
        private int MarkSubject1;
        private int MarkSubject2;
        private int result;

        private int invalidation;

        //Declare and initialize variables
        private bool bSubject1 = false;
        private bool bSubject2 = false;
        private bool bResult = false;


        public average()
        {
            InitializeComponent();
            //initialize variables on form constructor
            MarkSubject1 = 0;
            MarkSubject2 = 0;

            //Change the attribute
            txtAverage.ReadOnly = true;


        }

        private void average_Load(object sender, EventArgs e)
        {

        }

        private void txtsub01_Validating(object sender, CancelEventArgs e)
        {
            // clear error provider
            errorProvider.SetError(txtsub01, "");
            bSubject1 = false;
            if (!int.TryParse(txtsub01.Text, out invalidation ))
            {
                bSubject1 = true;
                errorProvider.SetError(txtsub01, "please fill the required field Subject 01");
            }
        }

        private void txtsub02_Validating(object sender, CancelEventArgs e)
        {
            // clear error provider
            errorProvider.SetError(txtsub02, "");
            bSubject2 = false;
            if (!int.TryParse(txtsub02.Text, out invalidation))
            {
                bSubject2 = true;
                errorProvider.SetError(txtsub02, "please fill the required field Subject 02");
            }

        }

        private void txtAverage_Validating(object sender, CancelEventArgs e)
        {
            // clear error provider
            errorProvider.SetError(txtAverage, "");
            bResult = false;
            if (!int.TryParse(txtAverage.Text, out invalidation))
            {
                bResult = true;
                errorProvider.SetError(txtAverage, "please fill the required field Average");
            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bSubject1 == false && bSubject2 == false)
                {
                    MarkSubject1 = int.Parse(txtsub01.Text);
                    MarkSubject2 = int.Parse(txtsub02.Text);

                    result = ((MarkSubject1 + MarkSubject2) / 2);

                    txtAverage.Text = result.ToString();
                    if (result >= 0 && result <= 40)
                    {
                        lblaverage.Text = "Grade F";
                    }
                    else if(result >= 0 && result <= 65)
                    {
                        lblaverage.Text = "Grade C ";
                    }
                    else if (result >= 65 && result <= 75)
                    {
                        lblaverage.Text = "Grade B";
                    }
                    else if (result >= 75 && result <= 100)
                    {
                        lblaverage.Text = "Grade A ";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
              

            
        }  
    }
}
