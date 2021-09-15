using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC470_P2
{
    public partial class FormSeeFish : Form
    {
        public FormSeeFish(string selectedFish)
        {
            InitializeComponent();
            _Fish = selectedFish;
        }
        private void LoadPictures()
        {
            //pictures get loaded
            switch (_Fish)
            {
                case Fish.Crappie:
                    pictureBox1.Image = Properties.Resources.Crappie;
                    break;
                case Fish.Perch:
                    pictureBox1.Image = Properties.Resources.Perch;
                    break;
                case Fish.Walleye:
                    pictureBox1.Image = Properties.Resources.Walleye;
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
