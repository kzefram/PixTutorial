using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Karen Bourgeois
// Class Tutorial for Picture Boxes and Events
// March 7, 2023

// This program is to demostrate how to use the picture buttons
// and events to change the pictures. 

// Icon: "https://www.freeiconspng.com/img/14981"
// Pic1: From a class presentation; origin unknown
// Pic2: "https://www.veemo.ca"
// Pic3: "https://www.better.bike"

namespace PixTutorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // This event changes the picture to the first picture
        private void btnPicture1_Click(object sender, EventArgs e)
        {
            picIcon.ImageLocation = @"C:\Pix\Veemo.png";
        }

        // This event changes the picture to the second picture
        private void button2_Click(object sender, EventArgs e)
        {
            picIcon.ImageLocation = @"C:\Pix\BetterBike.png";
        }
    }
}
