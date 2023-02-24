using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Mixer
{
    public partial class ColorMixer : Form
    {
        public ColorMixer()
        {
            InitializeComponent();
        }

        private void btnMix_Click(object sender, EventArgs e)
        { //this checks what two radio button colors are checked and turn the background color.

            if(rbRed.Checked && rbBlueTwo.Checked) //checks to see if these radio buttons are checked
            {
                this.BackColor = Color.Purple; //Change the back ground color
            }

            else if (rbRedTwo.Checked && rbBlue.Checked) //checks to see if these radio buttons are checked
            {
                this.BackColor = Color.Purple; //Change the back ground color
            }

            else if (rbRed.Checked && rbYellowTwo.Checked) //checks to see if these radio buttons are checked
            {
                this.BackColor = Color.Orange; //Change the back ground color
            }

            else if (rbRedTwo.Checked && rbYellow.Checked) //checks to see if these radio buttons are checked
            {
                this.BackColor = Color.Orange; //Change the back ground color
            }

            else if (rbBlue.Checked && rbYellowTwo.Checked) //checks to see if these radio buttons are checked
            {
                this.BackColor = Color.Green; //Change the back ground color
            }

            else if (rbBlueTwo.Checked && rbYellow.Checked) //checks to see if these radio buttons are checked
            {
                this.BackColor = Color.Green; //Change the back ground color
            }

            else if (rbRed.Checked && rbRedTwo.Checked) //checks to see if these radio buttons are checked
            {
                this.BackColor = Color.Red; //Change the back ground color
            }

            else if (rbBlue.Checked && rbBlueTwo.Checked) //checks to see if these radio buttons are checked
            {
                this.BackColor = Color.Blue; //Change the back ground color
            }

            else if (rbYellow.Checked && rbYellowTwo.Checked) //checks to see if these radio buttons are checked
            {
                this.BackColor = Color.Yellow; //Change the back ground color
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        { //this close the program
            this.Close();
        }
    }
}
